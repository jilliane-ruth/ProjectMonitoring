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
        private readonly SupabaseService _supabaseClient;

        public ContractorController(SupabaseService supabase)
        {
            _supabaseClient = supabase;

        }
        public async Task<IActionResult> Index()
        {
            var data = await _supabaseClient.GetDataFromSupabase();
            return View(data);
        }


    }
}
