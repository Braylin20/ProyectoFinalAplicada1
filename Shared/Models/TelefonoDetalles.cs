using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class TelefonoDetalles
    {
        [Key]
        public int DetalleId { get; set; }
        public string? Id { get; set; }
        [Required(ErrorMessage = "Este Campo Es Obligatorio.")]
        public int TipoId { get; set; }
        [Required(ErrorMessage = "Este Campo Es Obligatorio.")]
        public string Telefono { get; set; } = string.Empty;
        [ForeignKey("TipoId")]
        public TipoTelefonos? TipoTelefono { get; set; }
    }
}
