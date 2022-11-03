using CabañasProyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CabañasProyecto.Controllers
{
    public class ReservaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
