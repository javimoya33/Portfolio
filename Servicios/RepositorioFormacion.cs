using Portafolio4.Models;

namespace Portafolio4.Servicios
{
    public interface IRepositorioFormacion
    {
        List<Formacion> ObtenerFormacion();
    }

    public class RepositorioFormacion: IRepositorioFormacion
    {
        public List<Formacion> ObtenerFormacion()
        {
            return new List<Formacion>()
            {
                new Formacion
                {
                    Titulo = "Título en Desarrollo de Aplicaciones Web",
                    Subtitulo = "Técnico Superior de Formación Profesional",
                    Fecha = "Septiembre 2011 - Junio 2013",
                    HorasCurso = 2000,
                    Enlace = "../imagenes/titulos/Titulo_DAW.jpg",
                    Certificado = false
                },
                new Formacion
                {
                    Titulo = "Título en Desarrollo de Aplicaciones Multiplataforma",
                    Subtitulo = "Técnico Superior de Formación Profesional",
                    Fecha = "Septiembre 2013 - Junio 2017",
                    HorasCurso = 2000,
                    Enlace = "../imagenes/titulos/Titulo_DAM.jpg",
                    Certificado = false
                },
                new Formacion
                {
                    Titulo = "Certificado de Ionic 4: Crear aplicaciones iOS, Android y PWAs",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "Junio 2019",
                    HorasCurso = 31,
                    Enlace = "../imagenes/titulos/Titulo_Ionic.jpg",
                    Certificado = true
                },
                new Formacion
                {
                    Titulo = "Certificado de ASP.NET Core MVC 6",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "Enero 2023",
                    HorasCurso = 26,
                    Certificado = true,
                    Enlace = "../imagenes/titulos/Titulo_ASP_MVC.jpg",
                },
                new Formacion
                {
                    Titulo = "Certificado de Webs APIs RESTful con ASP.NET Core 6",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "Marzo 2023",
                    HorasCurso = 22,
                    Enlace = "../imagenes/titulos/Titulo_ASP_API.jpg",
                    Certificado = true
                },
                new Formacion
                {
                    Titulo = "Certificado de Máster en Webs Full Stack",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "En proceso",
                    HorasCurso = 35,
                    Enlace = "",
                    Certificado = true
                }
            };
        }
    }
}
