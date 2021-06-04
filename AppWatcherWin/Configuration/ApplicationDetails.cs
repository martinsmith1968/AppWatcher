namespace AppWatcherWin.Configuration
{
    public class ApplicationDetails
    {
        public int ProcessId { get; set; }

        public string FileName { get; set; }

        public string Arguments { get; set; }

        public ApplicationDetails(string fileName, string arguments)
        {
            FileName = fileName;
            Arguments = arguments;
        }
    }
}
