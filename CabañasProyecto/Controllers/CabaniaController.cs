using CabañasProyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace CabañasProyecto.Controllers
{
    public class CabaniaController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {
            List<Cabania>? cabanias = null;
            using (CabaniasContext context = new CabaniasContext())
            {
                cabanias = context.Cabanias.ToList();
            }
            return View(cabanias);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cabania cabania)
        {
            using (CabaniasContext context = new())
            {
                context.Cabanias.Add(cabania);
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public IActionResult Edit(int Id)
        {
            Cabania? cabania = null;
            using (CabaniasContext context = new())
            {
                cabania = context.Cabanias.Find(Id);
                if (cabania != null)
                {
                    return View(cabania);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Cabania cab)
        {
            using (CabaniasContext context = new())
            {
                if(id != cab.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    context.Cabanias.Update(cab);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public IActionResult Delete(Cabania cab)
        {
            using (CabaniasContext context = new())
            {
                if (cab != null)
                {
                    context.Cabanias.Remove(cab);
                    context.SaveChanges();
                }
            }
            return RedirectToAction(nameof(Index));
        }

    }
}

