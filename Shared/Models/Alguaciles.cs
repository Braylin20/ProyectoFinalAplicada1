using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class Alguaciles
    {
        [Key]
        public int AlguacilId { get; set; }
        [Required(ErrorMessage ="Introduce un nombre")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Introduce un Apellido")]
        public string? Apellido { get; set; }
    }
}
