using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Clave { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Rol { get; set; }
    }
}
