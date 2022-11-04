using CabañasProyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CabañasProyecto.Controllers
{
    public class ReservaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Reserva> reservas = new();
            using (CabaniasContext c = new())
            {
                reservas = c.Reservas.ToList();
            }
            return View(reservas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
