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
        public string? NombreDemandado { get; set; }
        //public string? NombreNino { get; set; }
        //public DateTime? FechaNacimientoNino { get; set; }
        //public string? Genero { get; set; }
    }
}
