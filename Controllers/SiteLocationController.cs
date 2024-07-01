using Microsoft.AspNetCore.Mvc;
using ProjectMonitoring.Models;

namespace ProjectMonitoring.Controllers
{
    public class SiteLocationController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
