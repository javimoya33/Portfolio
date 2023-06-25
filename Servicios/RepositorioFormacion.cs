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
                    Enlace = "www.marca.com",
                    Certificado = false
                },
                new Formacion
                {
                    Titulo = "Título en Desarrollo de Aplicaciones Multiplataforma",
                    Subtitulo = "Técnico Superior de Formación Profesional",
                    Fecha = "Septiembre 2013 - Junio 2017",
                    HorasCurso = 2000,
                    Enlace = "www.elmundo.es",
                    Certificado = false
                },
                new Formacion
                {
                    Titulo = "Certificado de Ionic 4: Crear aplicaciones iOS, Android y PWAs",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "Junio 2019",
                    HorasCurso = 31,
                    Enlace = "www.elmundo.es",
                    Certificado = true
                },
                new Formacion
                {
                    Titulo = "Certificado de ASP.NET Core MVC 6",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "Enero 2023",
                    HorasCurso = 26,
                    Enlace = "www.elmundo.es",
                    Certificado = true
                },
                new Formacion
                {
                    Titulo = "Certificado de Webs APIs RESTful con ASP.NET Core 6",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "Marzo 2023",
                    HorasCurso = 22,
                    Enlace = "www.elmundo.es",
                    Certificado = true
                },
                new Formacion
                {
                    Titulo = "Certificado de Máster en Webs Full Stack",
                    Subtitulo = "Curso Online de Udemy",
                    Fecha = "En proceso",
                    HorasCurso = 35,
                    Enlace = "www.elmundo.es",
                    Certificado = true
                }
            };
        }
    }
}
