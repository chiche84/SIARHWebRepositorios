using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Me.Siarh.Pof.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PofDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("defaultConnection")));           
            services.AddSingleton<ILogger>(svc => svc.GetRequiredService<ILogger<ApplicationLogs>>());
            
            return services;
        }
    }

    public class ApplicationLogs
    {
    }
}
