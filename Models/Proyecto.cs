namespace Portafolio4.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenURL { get; set; }
        public string Link { get; set; }
        public string GitHub { get; set; }
        public DateTime FechaRealizacion { get; set; }
    }
}
