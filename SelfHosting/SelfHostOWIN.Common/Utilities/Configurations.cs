using System.Configuration;

namespace SelfHostOWIN.Common.Utilities
{
    public class Configurations
    {
        private const string defaultServiceAddress = "http://localhost:18080/";

        public static string GetServiceAddress()
        {
            string baseAddress = ConfigurationManager.AppSettings.Get("BaseServiceAddress").Trim();

            return !string.IsNullOrWhiteSpace(baseAddress) ? baseAddress : defaultServiceAddress;
        }
    }
}
