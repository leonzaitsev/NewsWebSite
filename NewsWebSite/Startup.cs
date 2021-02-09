using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NewsWebSite
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                /* Часть кода из шаблона 
                  * endpoints.MapControllerRoute(
                       name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");
              */
                endpoints.MapGet("/", async context =>
                {
                    try
                    {
                        using (var connection = new MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=dbo"))
                        {
                            await connection.OpenAsync();
                            var command = connection.CreateCommand();
                            command.CommandText = "select * from article";
                            var reader = await command.ExecuteReaderAsync();

                            while (await reader.ReadAsync())
                            {
                                await context.Response.WriteAsync(reader["id"].ToString() + " " + reader["title"] + " " + reader["body"]);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        await context.Response.WriteAsync(e.ToString());
                    }
                });
            });
        }
    }

}

    
