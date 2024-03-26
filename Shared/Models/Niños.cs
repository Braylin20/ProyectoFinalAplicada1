using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Niños
    {
        [Key]
        public int NinoId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Genero { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaNacimiento { get; set; }
    }
}
