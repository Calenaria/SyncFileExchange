using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            LoadConfig();

            Application.Run(new MainFrame());
        }

        private static void LoadConfig()
        {
            string path = @"settings.conf";

            if (!File.Exists(path))
            {
                var config = new Dictionary<string, string>{
                    { "lastSyncTime", "0" } 
                };

                string settings = JsonConvert.SerializeObject(config);

                File.WriteAllText(path, settings);
            } else {
                File.ead
            }
        }
    }
}