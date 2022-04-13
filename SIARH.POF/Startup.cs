
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.OpenApi.Models;
 using Security;
using SIARH.POF.Persistence.UnitOfWork;
using MediatR;
using SIARH.POF.Application.Services;
using SIARH.POF.Persistence;
using SIARH.POF.Aplication.Common;
using SIARH.POF.Application.Entities.RefFuncionEntity.Services;
using AutoMapper;
using System.Reflection;

namespace Siarh.POF.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SecurityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("securityConnection")));
            services.AddDbContext<SiarhPofDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            services.AddSingleton<ILogger>(svc => svc.GetRequiredService<ILogger<ApplicationLogs>>());

            services.AddControllers();

            services.AddEndpointsApiExplorer();

            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddMaps(Assembly.GetExecutingAssembly());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id ="Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
            });
         

            services.AddDataProtection();

            services.AddSecurity(Configuration);

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("https://apirequest.io").AllowAnyMethod().AllowAnyHeader();
                });
            });
            services.AddHttpContextAccessor();

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PipelineSaveChanges<,>));
            services.AddMediatR(typeof(RefFuncionEventHandler));

            services.AddTransient<UnitOfWork>();
            services.AddTransient<RefFuncionService>();

        }



        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }

    public class ApplicationLogs
    {
    }
}
