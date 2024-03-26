using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class TipoResoluciones
    {
        [Key]
        public int ResolucionId { get; set; }
        public string? TipoResolcion { get; set; }
    }
}
