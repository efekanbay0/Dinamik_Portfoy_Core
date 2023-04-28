using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "Istatistikler";
            ViewBag.v3 = "Istatistikler Sayfasi";
            return View();
        }
    }
}
