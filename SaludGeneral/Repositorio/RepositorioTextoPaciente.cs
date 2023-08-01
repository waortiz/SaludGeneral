using SaludGeneral.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGeneral.Repositorio
{
    public class RepositorioTextoPaciente : IRepositorioPaciente
    {
        public void GuardarPaciente(Paciente paciente)
        {
            Console.WriteLine($"Paciente {paciente.NumeroDocumento} almacenado correctamente en el archivo de texto");
        }
    }
}
