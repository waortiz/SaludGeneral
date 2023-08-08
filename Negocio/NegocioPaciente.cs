using Entidades;
using Repositorio;

namespace Negocio
{
    public class NegocioPaciente :INegocioPaciente
    {
        private IRepositorioPaciente repositorio;

        public NegocioPaciente(IRepositorioPaciente repositorio)
        {
            this.repositorio = repositorio;
        }

        public void GuardarPaciente(Paciente paciente)
        {
            repositorio.GuardarPaciente(paciente);
        }
    }
}
