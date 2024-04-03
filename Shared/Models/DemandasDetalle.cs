using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class DemandasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int DemandaId { get; set; }
        [RegularExpression(@"^\d{11}$", ErrorMessage = "La cédula debe tener 11 digitos")]
        public string? NumCedulaDemandado { get; set; }
        [Required(ErrorMessage = "El nombre del demandante es requerido")]
        public string? NombreDemandado { get; set; }
        
    }
}
