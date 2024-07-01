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
        string url = Environment.GetEnvironmentVariable("https://bacucuxysqlosdlmrqev.supabase.co"); 
        string key = Environment.GetEnvironmentVariable("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJhY3VjdXh5c3Fsb3NkbG1ycWV2Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTgzMzI4MTMsImV4cCI6MjAzMzkwODgxM30.SiJmWFLYmK7ovn8bgsLMWP-ehfS5ZvfXmRouuLGHEHk");

        public ContractorController(SupabaseConfig supabaseConfig)
        {
            _supabaseClient = new Supabase.Client(supabaseConfig.Url, supabaseConfig.AnonKey);

        }

        [HttpPost]
        public IActionResult Create(Contractor contractor)
        {
            return View();
        }

    }
}
