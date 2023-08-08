using Entidades;

namespace Repositorio
{
    public class RepositorioTextoPaciente : IRepositorioPaciente
    {
        public void GuardarPaciente(Paciente paciente)
        {
            Console.WriteLine($"Paciente {paciente.NumeroDocumento} almacenado correctamente en el archivo de texto");
        }
    }
}
