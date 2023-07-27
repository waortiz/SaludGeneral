using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGeneral
{
    public class RepositorioTextoPaciente : RepositorioPaciente
    {
        public new void GuardarPaciente(Paciente paciente)
        {
            System.Console.WriteLine($"Paciente {paciente.NumeroDocumento} almacenado correctamente en el archivo de texto");
        }
    }
}
