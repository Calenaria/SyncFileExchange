using System.Windows.Forms;

namespace SyncFileExchange
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

            using (var authFrame = new AuthFrame())
            {
                if (authFrame.ShowDialog() == DialogResult.OK)
                {
                    var accountToken = authFrame.AccountToken;
                    Application.Run(new MainFrame(accountToken));
                }
            }
        }

    }
}