using Microsoft.AspNetCore.Mvc;

namespace HelpTechLanding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}