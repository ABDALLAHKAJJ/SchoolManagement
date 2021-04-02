using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Configuration;

namespace WebAPI

{
    public class Program
    {
        private static string URL = ConfigurationManager.AppSettings["URL"];

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //    .UseStartup<Startup>()
            //    .Build();
            //host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseKestrel(o =>
                    {
                        o.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(20);
                        o.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(2);
                    });
                    webBuilder.UseUrls(URL);
                }).UseWindowsService().ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Trace);
                }).UseNLog();
    }
}