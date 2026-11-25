using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Demo.Core.Interfaces;
using Microsoft.OpenApi.Models;
using Demo.API.Infrastructure.MiddleWares;
using Excepticon.Extensions;
using Excepticon.AspNetCore;
using AutoMapper;
using Demo.Repository.AutoMapper;
using System.Collections.Generic;
using Demo.Core.Model;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Demo.Repository.Repository;

namespace Demo
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<UATDemoPortalContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly("Demo.Core")));

            services.AddControllers();
            services.AddHttpClient();

            var appSettingsSection = Configuration.GetSection("AppSettings");
            var imageLogoPathSection = Configuration.GetSection("LogoImagePath");

            if (true)
            {
                // Register the Swagger generator, defining 1 or more Swagger documents
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1",
                        new OpenApiInfo
                        {
                            Title = "Demo",
                            Version = "v1"
                        });
                    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                    {
                        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "bearer"
                    });
                    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                    {
                {
                    new OpenApiSecurityScheme
                    {
                    Reference = new OpenApiReference
                        {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                        },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header,

                    },
                    new List<string>()
                    }
                    });
                });
            }
            services.AddExcepticon();
            services.AddBrowserDetection();
            services.AddTransient<ISuppliersRepository, SuppliersRepository>();
            services.AddTransient<ILocationsRepository, LocationsRepository>();
            services.AddTransient<ILookupRepository, LookupsRepository>();
            services.AddTransient<IPanelBeatersRepository, PanelBeatersRepository>();
            services.AddTransient<IClaimsRepository, ClaimsRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IAPILogRepository, APILogRepository>();
            services.AddTransient<IInsurerRepository, InsurerRepository>();


            //services.AddAutoMapper(typeof(Startup));

            MapperConfiguration mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CreateServiceMap());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            // Configure jwt authentication
            var key = Encoding.ASCII.GetBytes(Configuration["AuthSettings:Key"]);

            services.AddAuthentication(x =>
           {
               x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
               x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
           })
           .AddJwtBearer(x =>
           {
               x.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = new SymmetricSecurityKey(key),
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidIssuer = Configuration["AuthSettings:Issuer"],
                   ValidAudience = Configuration["AuthSettings:Audience"]
               };
           });

        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo");
            });
            app.UseMiddleware(typeof(ApplicationMiddleware));
            app.UseExcepticon();
            app.UseRouting();
            app.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => true)
            .AllowCredentials());
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}


