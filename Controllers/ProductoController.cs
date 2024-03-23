using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Models;

namespace TechStore.Controllers
{
    public class ProductoController : Controller
    {
         private readonly ILogger<ProductoController> _logger;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
    
        public IActionResult Create([Bind("Nombre,Descripcion,Precio")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                
               producto.calcularIgv();
               ViewData["Message"] = "¡Producto registrado!. \nEl producto con IGV es de: S/. " + producto.PrecioIgv;
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