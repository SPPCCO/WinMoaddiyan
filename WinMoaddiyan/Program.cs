namespace WinMoaddiyan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            if(string.IsNullOrEmpty(Properties.Settings.Default.Token))
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new MainForm());
            }
            
        }
    }
}