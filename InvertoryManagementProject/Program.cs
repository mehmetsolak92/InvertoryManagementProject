namespace InvertoryManagementProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            using (scr_Splash scr_Splash = new scr_Splash())
            {
                if (scr_Splash.ShowDialog() != DialogResult.OK)
                {
                    return; 
                }
            }

          
            scr_UserLogin scr_UserLogin = new scr_UserLogin();
            if (scr_UserLogin.ShowDialog() == DialogResult.OK) 
            {
                Application.Run(new scr_Main());
            }
        }
    }
}