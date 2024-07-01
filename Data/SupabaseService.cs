using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProjectMonitoring.Models;

namespace ProjectMonitoring.Data
{
    public class SupabaseService
    {
        private readonly HttpClient _httpClient;
        private readonly string _functionUri;
        private readonly string _anonKey;

        public IConfiguration Configuration { get; }
        public SupabaseService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var supabaseConfig = new SupabaseConfig
            {
                Url = Environment.GetEnvironmentVariable("SUPABASE_URL"),
                AnonKey = Environment.GetEnvironmentVariable("SUPABASE_ANON_KEY")
            };
            services.AddSingleton(supabaseConfig);

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
public class SupabaseConfig
{
    public string Url { get; set; }
    public string AnonKey { get; set; }
}