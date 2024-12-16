using System.Diagnostics;

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
    }
}
