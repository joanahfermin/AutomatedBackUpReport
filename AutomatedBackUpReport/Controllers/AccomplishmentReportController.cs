using Microsoft.AspNetCore.Mvc;

namespace AutomatedBackUpReport.Controllers
{
    public class AccomplishmentReportController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.month = DateTime.Now.Month;
            ViewBag.year = DateTime.Now.Year;
            ViewBag.Kamote = "abc";

            return View();
        }
    }
}
