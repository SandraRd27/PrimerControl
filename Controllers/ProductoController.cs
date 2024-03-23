using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mymovieapp.Models;

namespace mymovieapp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Nombre del prodcuto,Descripcion,Precio")] Cliente cleinte)
        {
            if (ModelState.IsValid)
            {
                ViewData["Message"] = "El producto se ha registrado";
                if(producto.Nombre.Equals("arroz") && producto.Descripcion.Equals("arroz integral") ){
                    ViewData["Message"] = "El producto esta registrado. El prodcuto tiene un IGV de: S/. 11.7999";
                }
                return View("Index");
            }
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
