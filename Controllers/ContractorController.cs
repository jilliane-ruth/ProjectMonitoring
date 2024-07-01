using Microsoft.AspNetCore.Mvc;
using ProjectMonitoring.Models;

namespace ProjectMonitoring.Controllers
{
    public class ContractorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
