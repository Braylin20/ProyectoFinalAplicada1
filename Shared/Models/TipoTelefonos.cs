using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class TipoTelefonos
    {
        [Key]
        public int TipoTelefonoId { get; set; }
        public string? Descripcion { get; set; }
    }
}
