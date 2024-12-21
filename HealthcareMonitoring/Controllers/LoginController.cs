using HealthcareMonitoring.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareMonitoring.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
