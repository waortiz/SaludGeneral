using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGeneral
{
    public abstract class RepositorioPaciente
    {
        public void GuardarPaciente(Paciente paciente)
        {
            System.Console.WriteLine($"Paciente {paciente.NumeroDocumento} almacenado correctamente");
        }
    }
}
