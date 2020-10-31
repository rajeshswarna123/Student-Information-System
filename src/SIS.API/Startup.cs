using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SIS.Core.ClientContext;
using SIS.Core.JWTHelper;
using SIS.Data;
using SIS.Data.Configurations;
using SIS.Entities;
using SIS.Interfaces.Repositories;
using SIS.Interfaces.Services;
using SIS.Services;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SIS.Core.AutoMapperProfile;
using AutoMapper;

namespace SIS.API
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
            services.AddControllersWithViews();

            services.AddRazorPages();

            services.AddControllers();

            services.AddHttpContextAccessor();

            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            ConfigureSettings(services);
            
            ConfigureDBSettings(services);

            //Dependency Injection
            ConfigureIOC(services);

            ConfigureAuth(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }

        public void ConfigureSettings(IServiceCollection services)
        {
            services.Configure<DBSettings>(Configuration.GetSection("DBSettings"));
            services.AddSingleton(r => r.GetRequiredService<IOptions<DBSettings>>().Value);

            services.Configure<JwtIssuerOptions>(Configuration.GetSection(nameof(JwtIssuerOptions)));
            services.AddSingleton(r => r.GetRequiredService<IOptions<JwtIssuerOptions>>().Value);
        }

        public void ConfigureDBSettings(IServiceCollection services)
        {
            services.AddDbContext<SISDBContext>(options => options.UseSqlServer(Configuration.GetSection("DBSettings:ConnectionString").Value));

        }

        public void ConfigureIOC(IServiceCollection services)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IClientContext, ClientContext>();

            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped<IStudentService, StudentService>();


            services.AddScoped<ISecurityRepository, SecurityRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IClassCurriculumRepository, ClassCurriculumRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IMarksRepository, MarksRepository>();

        }

        public void ConfigureAuth(IServiceCollection services)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = Configuration["JwtIssuerOptions:Issuer"],

                ValidateAudience = true,
                ValidAudience = Configuration["JwtIssuerOptions:Audience"],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration["Secret"].ToString())),

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.RequireHttpsMetadata = false;
                configureOptions.ClaimsIssuer = Configuration["JwtIssuerOptions:Issuer"];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
                options.HttpOnly = HttpOnlyPolicy.None;
            });
        }
    }
}
