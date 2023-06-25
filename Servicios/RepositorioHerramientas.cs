using Dapper;
using Portafolio4.Models;
using System.Data.SqlClient;

namespace Portafolio4.Servicios
{
    public interface IRepositorioHerramientas
    {
        Task<IEnumerable<Herramienta>> ObtenerHerramientas();
    }

    public class RepositorioHerramientas: IRepositorioHerramientas
    {
        private readonly string connectionString; 

        public RepositorioHerramientas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Herramienta>> ObtenerHerramientas()
        {
            using var connection = new SqlConnection(connectionString);

            return await connection.QueryAsync<Herramienta>(
                @"SELECT pro.Id AS IdPro, her.Nombre, her.ColorLetra, her.ColorFondo
                    FROM Herramientas as Her, Proyectos_Herramientas as PH, Proyectos AS pro
                    WHERE Her.Id = PH.HerramientaId AND pro.Id = PH.ProyectoId");
        }
    }
}
