using Microsoft.AspNetCore.Mvc;
using ProjectMonitoring.Models;

namespace ProjectMonitoring.Controllers
{
    public class IssueReportController : Controller
    {
        public IActionResult IssueReport()
        {
            return View();
        }

        //Display
        

        //ISSUE REPORT - EDIT, CREATE, DELETE
        //CREATE Issue Report
        [HttpPost]
        public IActionResult Create(IssueReport issueReport)
        {
            return View();
        }




    }
}
