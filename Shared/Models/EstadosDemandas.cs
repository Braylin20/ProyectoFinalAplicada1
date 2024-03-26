using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class EstadosDemandas
    {
        [Key]
        public int EstadoId { get; set; }
        public string? Estado { get; set; }
    }
}
