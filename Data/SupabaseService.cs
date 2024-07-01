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

        

    }
}
public class SupabaseConfig
{
    public string Url { get; set; }
    public string AnonKey { get; set; }
}