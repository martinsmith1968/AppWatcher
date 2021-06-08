using System.Text.Json;
using AppWatcherWin.Configuration;

namespace AppWatcherWin.Converters
{
    public class JsonSerializationConverter
    {
        public static string ToJson(ApplicationDetails applicationDetails)
        {
            return JsonSerializer.Serialize(applicationDetails);
        }

        public static ApplicationDetails FromJson(string json)
        {
            return JsonSerializer.Deserialize<ApplicationDetails>(json);
        }
    }
}
