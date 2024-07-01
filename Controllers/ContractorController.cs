using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Microsoft.AspNetCore.Routing.Tree;
using ProjectMonitoring.Data;
using ProjectMonitoring.Models;
using Supabase;

namespace ProjectMonitoring.Controllers
{
    public class ContractorController : Controller
    {
        private readonly Supabase.Client _supabaseClient;
       
        public ContractorController(SupabaseConfig supabaseConfig)
        {
            _supabaseClient = new Supabase.Client(supabaseConfig.Url, supabaseConfig.AnonKey);

        }

        [HttpPost]
        public IActionResult Index()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "SUPABASE_URL");
            return View();
        }

    }
}
