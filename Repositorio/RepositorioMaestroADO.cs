using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestroADO : IRepositorioMaestro
    {
        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();

            string cadenaConexion = ConfigurationManager.ConnectionStrings["SaludGeneral"]
                .ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                var comando = new SqlCommand();
                comando.CommandText = "SELECT Id, Nombre FROM TiposDocumento ORDER by Nombre";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposDocumento.Add(new TipoDocumento()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = Convert.ToString(reader["Nombre"])
                        });
                    }
                }
            }

            return tiposDocumento;
        }
    }
}
