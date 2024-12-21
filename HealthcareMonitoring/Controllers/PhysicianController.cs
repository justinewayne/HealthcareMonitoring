using HealthcareMonitoring.Data;
using HealthcareMonitoring.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareMonitoring.Controllers
{
    public class PhysicianController : Controller
    {
        readonly ApplicationDbContext _db;
        public PhysicianController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Physician> objPhysician;
            objPhysician = _db.Physicians.ToList();
            return View(objPhysician);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
