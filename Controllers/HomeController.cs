using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notas.Models;

namespace Notas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NotasContext db;

        public HomeController(ILogger<HomeController> logger, NotasContext contexto)
        {
            this.db = contexto;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View( db.Nota.ToList() );
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SaveNota( string titulo, string cuerpo ){

            Nota nuevaNota = new Nota{
                Titulo = titulo,
                Cuerpo = cuerpo
            };

            db.Nota.Add( nuevaNota );
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // LOGIN USUARIO
        public IActionResult Login( bool userExist = true )
        {
            return View();
        }

        public IActionResult VerificarUsuario( string Usuario, string Password )
        {
            // Imprimir en consola datos del usuario 
            Console.WriteLine($"Nombre usario:{Usuario}, contraseña: {Password}");

            // Verificar logica!!!
            if(Usuario == null) {
                this.ViewBag.usuarioExist = "Prueba";
                return RedirectToAction("Login");
            }
            else
            {
                this.ViewBag.usuarioExist = "existe";
                return RedirectToAction("Index");
            }
            
        }


        // REGISTER USER
        public IActionResult Register()
        {
            return View();
        }
    }
}
