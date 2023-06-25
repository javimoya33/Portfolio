using Dapper;
using Portafolio4.Models;
using System.Data.SqlClient;

namespace Portafolio4.Servicios
{ 
    public interface IRepositorioProyectos
    {
        Task<IEnumerable<Proyecto>> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        private readonly string connectionString;

        public RepositorioProyectos(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Proyecto>> ObtenerProyectos()
        {
            using var connection = new SqlConnection(connectionString);

            return await connection.QueryAsync<Proyecto>(
                @"SELECT pro.Id, pro.Nombre, pro.Descripcion, pro.ImagenURL, pro.Link, pro.GitHub
                    FROM Proyectos AS pro");
        }
    }
}
