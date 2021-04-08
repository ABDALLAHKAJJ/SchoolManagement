using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Libraries.Core.Security.Encryption;

namespace SchoolManagement.Data.Connections
{
    public class ConnectionManager
    {
        public static string GetConnectionString()
        {
            var Key = ConfigurationManager.AppSettings["Key"];
            //Server=DESKTOP-6E0MHSD\\APO;Database=SchoolManagement;Trusted_Connection=True;
            return $"Data Source={AesEncryption.Decrypt(ConfigurationManager.AppSettings["ServerName"], Key)};Database={AesEncryption.Decrypt(ConfigurationManager.AppSettings["DatabaseName"], Key)};Trusted_Connection=True;";
        }
    }
}