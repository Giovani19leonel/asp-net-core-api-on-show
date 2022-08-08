using IntegrationAPIOnShow.Configurations;
using IntegrationAPIOnShow.Core.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IntegrationAPIOnShow
{
    public class Startup
    {
        public IConfiguration _configuration { get; }
        public AppSettings _settings;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
            _settings = new AppSettings(_configuration);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCoreServices(_configuration);
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("https://localhost:8001", "https://localhost:8001")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
                        });
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
               
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
