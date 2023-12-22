namespace SyncFileExchange.Handlers
{
    internal class FileHandler
    {
        private static readonly string TRACKED_FILES = "tracked.json";

        public FileHandler()
        {
            if (File.Exists(TRACKED_FILES))
            {

            }
        }
    }
}
