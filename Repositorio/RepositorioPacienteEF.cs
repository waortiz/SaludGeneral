using Entidades;

namespace Repositorio
{
    public class RepositorioPacienteEF : IRepositorioPaciente
    {
        private Modelo.Contexto contexto = new Modelo.Contexto();
        public void GuardarPaciente(Paciente paciente)
        {
            var pacienteNuevo = new Modelo.Paciente()
            {
                PrimerNombre = paciente.PrimerNombre,
                SegundoNombre = paciente.SegundoNombre,
                PrimerApellido = paciente.PrimerApellido,
                SegundoApellido = paciente.SegundoApellido,
                IdTipoDocumento = paciente.TipoDocumento.Id,
                IdSexo = paciente.Sexo.Id,
                Copago = paciente.Copago,
                FechaNacimiento = paciente.FechaNacimiento,
                NumeroDocumento = paciente.NumeroDocumento,
                Titular= paciente.Titular
            };

            contexto.Pacientes.Add(pacienteNuevo);
            contexto.SaveChanges();
        }
    }
}
