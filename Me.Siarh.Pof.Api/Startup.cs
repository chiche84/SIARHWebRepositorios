
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.OpenApi.Models;
 using Security;
using MediatR;
using AutoMapper;
using System.Reflection;
using Me.Siarh.Pof.Persistence;
using Me.Siarh.Pof.Persistence.UnitOfWork;
using Me.Siarh.Pof.Application.RefFuncionEntity.Services;
using Me.Siarh.Pof.Application;
using Me.Siarh.Pof.Application.RefFuncionEntity.Handlers;

namespace Me.Siarh.Pof.Api
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

            services.AddApplication();

            services.AddControllers();

            services.AddPersistence(Configuration);
            services.AddEndpointsApiExplorer();



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
