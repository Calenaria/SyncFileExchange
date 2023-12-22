using Newtonsoft.Json;

namespace SyncFileExchange.Handlers
{
    internal class SettingsHandler
    {
        //file is in json format
        private static readonly string SETTING_PATH = @"settings.json";
        public SettingsHandler()
        {
            if (!File.Exists(SETTING_PATH))
            {
                create();
            }
        }

        public Dictionary<string, string> retrieve()
        {
            string json = File.ReadAllText(SETTING_PATH);
            var settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            if (settings == null)
            {
                throw new Exception("Could not retrieve settings.json!");
            }

            return settings;
        }

        public Dictionary<string, string> create()
        {
            var settings = new Dictionary<string, string>
            {
                { "user_uuid", "" },
                { "sync_interval", "10" }
            };

            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(SETTING_PATH, json);
            return settings;
        }
    }
}
