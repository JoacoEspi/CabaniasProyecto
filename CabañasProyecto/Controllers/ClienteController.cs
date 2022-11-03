using CabañasProyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CabañasProyecto.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Cliente> clientes = null;
            using (CabaniasContext context = new CabaniasContext())
            {
                clientes = context.Clientes.ToList();   
            }
            return View(clientes);
        }
    }
}
