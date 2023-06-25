using Microsoft.AspNetCore.Mvc;
using Portafolio4.Models;
using Portafolio4.Servicios;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace Portafolio4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IRepositorioFormacion repositorioFormacion;
        private readonly IRepositorioHerramientas repositorioHerramientas;
        private readonly ServicioDelimitado servicioDelimitado;
        private readonly ServicioTransitorio servicioTransitorio;
        private readonly ServicioUnico servicioUnico;
        private readonly ServicioDelimitado servicioDelimitado2;
        private readonly ServicioTransitorio servicioTransitorio2;
        private readonly ServicioUnico servicioUnico2;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos, 
            IRepositorioFormacion repositorioFormacion, IRepositorioHerramientas repositorioHerramientas,
            ServicioDelimitado servicioDelimitado, ServicioTransitorio servicioTransitorio, ServicioUnico servicioUnico,
            ServicioDelimitado servicioDelimitado2, ServicioTransitorio servicioTransitorio2, ServicioUnico servicioUnico2, 
            IConfiguration configuration)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.repositorioFormacion = repositorioFormacion;
            this.repositorioHerramientas = repositorioHerramientas;
            this.servicioDelimitado = servicioDelimitado;
            this.servicioTransitorio = servicioTransitorio;
            this.servicioUnico = servicioUnico;

            this.servicioDelimitado2 = servicioDelimitado2;
            this.servicioTransitorio2 = servicioTransitorio2;
            this.servicioUnico2 = servicioUnico2;
            this.configuration = configuration;

            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var apellido = configuration.GetValue<string>("Apellido");
            _logger.LogInformation("Este es un mensaje de log " + apellido);

            //var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var guidViewModel = new EjemploGuidViewModel()
            {
                Delimitado = servicioDelimitado.ObtenerGuid,
                Transitorio = servicioTransitorio.ObtenerGuid,
                Unico = servicioUnico.ObtenerGuid
            };

            var guidViewModel2 = new EjemploGuidViewModel()
            {
                Delimitado = servicioDelimitado2.ObtenerGuid,
                Transitorio = servicioTransitorio2.ObtenerGuid,
                Unico = servicioUnico2.ObtenerGuid
            };

            var modelo = new HomeIndexViewModel()
            {
                //Proyectos = proyectos,
                EjemploGuid_1 = guidViewModel,
                EjemploGuid_2 = guidViewModel2
            };

            return View(modelo);
        }

        [HttpGet]
        public IActionResult SobreMi()
        {
            return View();
        }

        public async Task<IActionResult> Proyectos()
        {
            var proyectos = await repositorioProyectos.ObtenerProyectos();
            var herramientas = await repositorioHerramientas.ObtenerHerramientas(); 

            var modelo = new ProyectoHerramientaViewModel()
            {
                proyectos = proyectos,
                herramientas = herramientas
            };

            return View(modelo);
        }

        [HttpGet]
        public IActionResult Formacion()
        {
            var formacion = repositorioFormacion.ObtenerFormacion();

            return View(formacion);
        }

        [HttpGet]
        public IActionResult Habilidades()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            string emailDestino = "javimoya33@gmail.com";
            string emailOrigen = contactoViewModel.Email;
            string asunto = "Contacto desde mi portfolio de " + contactoViewModel.Nombre;
            string cuerpo = $"Nombre: {contactoViewModel.Nombre}\nEmail: {contactoViewModel.Email}\nMensaje: {contactoViewModel.Mensaje}";

            string emailPassword = "bvzowuwblzmayraq";

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailOrigen);
                mail.To.Add(emailDestino);
                mail.Subject = asunto;
                mail.Body = cuerpo;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(emailDestino, emailPassword);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }

            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}