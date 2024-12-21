using HealthcareMonitoring.Data;
using HealthcareMonitoring.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthcareMonitoring.Controllers
{
    public class PatientController : Controller
    {
        readonly ApplicationDbContext _db;
        public PatientController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Patient> objPatient;
            objPatient = _db.Patients.ToList();
            return View(objPatient);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
