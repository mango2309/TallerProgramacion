using System.ComponentModel.DataAnnotations;

namespace TallerProgramacion.Models
{
    public class Burguer
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        [VerificarRango]
        public decimal Precio { get; set; }
    }
    public class VerificarRango : ValidationAttribute
    {
        
    }
}
