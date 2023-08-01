using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGeneral.Entidades
{
    public class TipoDocumento : IMaestro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
