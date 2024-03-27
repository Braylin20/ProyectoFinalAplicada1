using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class UsuarioDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public string Id { get; set; }
        public string? NombreAbogado { get; set; }
        public int? ColegioAbogadoId { get; set; }
    }
}
