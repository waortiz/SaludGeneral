using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMaestro : INegocioMaestro
    {
        private IRepositorioMaestro repositorioMaestro;

        public NegocioMaestro()
        {
            repositorioMaestro = new RepositorioMaestroADO();
        }

        public NegocioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            return repositorioMaestro.ObtenerTiposDocumento();
        }
    }
}
