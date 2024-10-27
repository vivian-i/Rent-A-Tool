using Microsoft.AspNetCore.Mvc;

namespace RentAToolWebApp.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
