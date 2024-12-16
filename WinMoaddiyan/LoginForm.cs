using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RSecurityBackend.Models.Auth.ViewModels;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace WinMoaddiyan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = "https://app.moaddiyan.com",
                UseShellExecute = true,
                Verb = "open",
            };
            Process.Start(info);
            Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Enabled = false;
            Application.DoEvents();

            LoginViewModel model = new LoginViewModel()
            {
                Username = txtEmail.Text,
                Password = txtPassword.Text,
                ClientAppName = "WinMoaddiyan",
                Language = "fa-IR"
            };
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var response = await httpClient.PostAsync
                        (
                        "https://api.moaddiyan.com/api/users/login",
                        new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json")
                        );
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Cursor = Cursors.Default;
                        Enabled = true;
                        MessageBox.Show(JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync()));
                        return;
                    }
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();

                    LoggedOnUserModel? loggedOnUser = JsonConvert.DeserializeObject<LoggedOnUserModel>(json);
                    if (loggedOnUser != null)
                    {
                        Properties.Settings.Default.LoggenOnUserJson = json;
                        Properties.Settings.Default.Token = loggedOnUser.Token;
                        Properties.Settings.Default.SessionId = loggedOnUser.SessionId;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
           

            Enabled = true;
            Cursor = Cursors.Default;
            //Open Main Window
        }
    }
}
