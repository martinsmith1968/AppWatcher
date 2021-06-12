using AppWatcher.Configuration;

namespace AppWatcher.Execution
{
    public class ActiveApplication
    {
        public ApplicationDetails ApplicationDetails { get; }

        public int? ProcessId { get; set; }

        public bool IsStarted => ProcessId.HasValue;

        public ActiveApplication(ApplicationDetails applicationDetails)
        {
            ApplicationDetails = applicationDetails;
        }
    }
}
