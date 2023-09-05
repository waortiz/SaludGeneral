using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public class Paciente
    {
        [Key]
        public long IdPaciente { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdTipoDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdSexo { get; set; }
        public bool Titular { get; set; }
        public decimal Copago { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual Sexo Sexo { get; set; }

    }
}