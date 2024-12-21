using Newtonsoft.Json;
using RSecurityBackend.Models.Auth.ViewModels;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace WinMoaddiyan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از خروج از حساب کاربری خود اطمینان دارید؟", "تأییدیه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign) == DialogResult.No)
            {
                return;
            }

            LoggedOnUserModel? loggedOnUser = JsonConvert.DeserializeObject<LoggedOnUserModel>(Properties.Settings.Default.LoggenOnUserJson);
            if (loggedOnUser == null)
            {
                Properties.Settings.Default.LoggenOnUserJson = "";
                Properties.Settings.Default.Token = "";
                Properties.Settings.Default.SessionId = Guid.Empty;
                Properties.Settings.Default.Save();

                Application.Restart();
                return;
            }

            Enabled = false;
            Application.DoEvents();

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {

                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.Token);
                    var response = await httpClient.DeleteAsync
                        (
                        $"https://api.moaddiyan.com/api/users/delsession?userId={loggedOnUser.User.Id}&sessionId={Properties.Settings.Default.SessionId}"
                        );
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
                        return;
                    }
                    response.EnsureSuccessStatusCode();
                    

                    Properties.Settings.Default.LoggenOnUserJson = "";
                    Properties.Settings.Default.Token = "";
                    Properties.Settings.Default.SessionId = Guid.Empty;
                    Properties.Settings.Default.Save();

                    Application.Restart();
                }
            }
            catch (Exception exp)
            {
                Enabled = true ;
                MessageBox.Show(exp.ToString());
            }
            

           
        }
    }
}
