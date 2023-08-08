using Entidades;

namespace Repositorio
{
    public abstract class RepositorioPaciente
    {
        public void GuardarPaciente(Paciente paciente)
        {
            Console.WriteLine($"Paciente {paciente.NumeroDocumento} almacenado correctamente");
        }
    }
}
