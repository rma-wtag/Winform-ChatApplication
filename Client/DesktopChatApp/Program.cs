using Microsoft.VisualBasic.Logging;

namespace DesktopChatApp
{
    internal static class Program
    {
        public static Form1 form1;
        public static Form3 form3;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            while (true)
            {
                using (Form1 loginForm = new Form1())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new Form3(loginForm.LoggedInUsername));
                    }
                    else
                    {
                        break;
                    }
                }
            }

            //Form4 form4 = new Form4();
            //Application.Run(form4);
        }
    }
}