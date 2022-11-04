﻿using CabañasProyecto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            using(CabaniasContext context = new CabaniasContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            using(CabaniasContext context = new())
            {
                Cliente? cliente = context.Clientes.Find(id);

                if (cliente != null)
                {
                    return View(cliente);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
          
        }
        [HttpPost]
        public IActionResult Edit(int id, Cliente cliente)
        {
          using(CabaniasContext context = new())
            {
                if (id != cliente.Id)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    context.Clientes.Update(cliente);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public IActionResult Delete(Cliente cliente)
        {
            using (CabaniasContext context = new())
            {
                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
