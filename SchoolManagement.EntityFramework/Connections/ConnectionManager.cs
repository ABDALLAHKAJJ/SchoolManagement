using SchoolManagement.Libraries.Core.Security.Encryption;
using System.Configuration;

namespace SchoolManagement.Data.Connections
{
    public static class ConnectionManager
    {
        public static string GetConnectionString()
        {
            var Key = ConfigurationManager.AppSettings["Key"];
            return $"Data Source={AesEncryption.Decrypt(ConfigurationManager.AppSettings["ServerName"], Key)};Database={AesEncryption.Decrypt(ConfigurationManager.AppSettings["DatabaseName"], Key)};Trusted_Connection=True;";
        }
    }
}