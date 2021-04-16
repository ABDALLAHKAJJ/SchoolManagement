using Microsoft.Extensions.DependencyInjection;
using SchoolManagement.Libraries.Core.Abstracts;
using SchoolManagement.Libraries.Core.Logging;

namespace SchoolManagement.Libraries.Core.Extension
{
    public static class ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggingManager, LoggingManager>();
        }
    }
}