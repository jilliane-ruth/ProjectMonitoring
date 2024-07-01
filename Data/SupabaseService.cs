using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProjectMonitoring.Models;
using Newtonsoft.Json;

namespace ProjectMonitoring.Data
{
    public class SupabaseService
    {
        private readonly IHttpClientFactory _httpClient;
        public IConfiguration Configuration { get; }
        public void ConfigurationService(IServiceCollection services)
        {

            var supabaseSettings = Configuration.GetSection("Supabase");
            services.AddSingleton(new Supabase.Client(supabaseSettings["FunctionUrl"], supabaseSettings["AnonKey"]));
        }

        public async Task<List<Contractor>> GetDataFromSupabase()
        {
            var client = _httpClient.CreateClient("Supabase");
            var response = await client.GetAsync("/rest/v1/Contractor"); // Replace with your actual table or endpoint

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Contractor>>();
            }
            else
            {
                // Handle error
                return new List<Contractor>();
            }
        }



    }
}
