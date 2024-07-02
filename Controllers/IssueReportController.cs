using Microsoft.AspNetCore.Mvc;
using ProjectMonitoring.Models;
using Supabase;

namespace ProjectMonitoring.Controllers
{
    public class IssueReportController : Controller
    {
        private readonly Supabase.Client _supabase;

        public IssueReportController(Supabase.Client supabase)
        {
            _supabase = supabase;
        }
        
        //DISPLAY
        public async Task<IActionResult> Index()
        {
            var response = await _supabase.From<IssueReport>().Order("issuereport_id",
                Supabase.Postgrest.Constants.Ordering.Ascending).Get();
            var issueReports = response.Models;
            return View(issueReports);
        }

        //ISSUE REPORT - CREATE, EDIT, DELETE
        //CREATE Issue Report
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IssueReport issueReport)
        {
            if (ModelState.IsValid)
            {
                var resp = await _supabase.From<IssueReport>().Insert(issueReport);
                    
                    
                return RedirectToAction(nameof(Index));
            }
            return View(issueReport);
        }
       

    }
}
