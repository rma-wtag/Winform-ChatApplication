using Microsoft.VisualBasic.Logging;

namespace DesktopChatApp
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
            Form1 form1 = new Form1();

            if (form1.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form3(form1.LoggedInUsername));
            }
        }
    }
}