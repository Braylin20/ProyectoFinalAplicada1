using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class NinoDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int DemandaId { get; set; }
        public string? NombreNino { get; set; }
        public DateTime? FechaNacimientoNino { get; set; }
        public string? Genero { get; set; }
    }
}
