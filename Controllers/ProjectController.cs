using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Project = ProjectMonitoring.Models.Project;

namespace ProjectMonitoring.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
