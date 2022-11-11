using CabañasProyecto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace CabañasProyecto.Controllers
{

    public class ReservaController : Controller
    {
        // Averiguar como poner un menu desplegable
        [HttpGet]
        public IActionResult Index()
        {
            List<Cabania> reservas = new();
            using (CabaniasContext c = new())
            {
                //Linq
                //List<Cabania> reservas2 = (from ca in c.Cabanias where ca.Estado == true select ca).ToList();
                reservas = c.Cabanias.Where(pepe => pepe.Estado).ToList(); // sentencia lamba
            }
            return View(reservas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<Cabania> reservas = new();
            using (CabaniasContext c = new())
            {
                reservas = c.Cabanias.Where(c => !c.Estado).ToList();
                ViewBag.Cabanias = reservas;
            }
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(Reserva reserva)
        {
            Cabania? cabania = null;
            using (CabaniasContext c = new CabaniasContext())
            {
                reserva.IdCabania = reserva.Id;
                reserva.Id = 0;
                c.Reservas.Add(reserva);
                cabania = c.Cabanias.Find(reserva.IdCabania);
                if (cabania != null)
                {
                    cabania.Estado = true;
                    c.SaveChanges();
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

 

