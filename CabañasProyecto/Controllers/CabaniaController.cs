using CabañasProyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CabañasProyecto.Controllers
{
    public class CabaniaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
                List<Cabania> cabanias = null;
                using (CabaniasContext context = new CabaniasContext())
                {
                    cabanias = context.Cabanias.ToList();
                }
                return View(cabanias);
        }
    }
}
