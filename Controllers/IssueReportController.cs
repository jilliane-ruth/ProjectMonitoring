using Microsoft.AspNetCore.Mvc;

namespace ProjectMonitoring.Controllers
{
    public class IssueReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
