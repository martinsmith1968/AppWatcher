using System.Diagnostics;

namespace AppWatcherWin.Configuration
{
    public class ApplicationDetails
    {
        public int ProcessId { get; set; }

        public string? DisplayName { get; set; }

        public string? FileName { get; set; }

        public string? Arguments { get; set; }

        public string? WorkingDirectory { get; set; }

        public bool CreateNoWindow { get; set; }

        public bool UseShellExecute { get; set; }

        public ProcessWindowStyle WindowStyle { get; set; }

        public string? Verb { get; set; }
    }
}
