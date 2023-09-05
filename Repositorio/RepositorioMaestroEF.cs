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
    public class RepositorioMaestroEF : IRepositorioMaestro
    {
        private Modelo.Contexto contexto = new Modelo.Contexto();
        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            return contexto.TiposDocumento.OrderBy(t => t.Nombre).
                Select(t => new TipoDocumento() { Id = t.Id, Nombre = t.Nombre }).ToList();
        }
    }
}
