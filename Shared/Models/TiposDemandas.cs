using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class TiposDemandas
    {
        [Key]
        public int TiposDemandasId { get; set; }
        public string? TipoDemanda { get; set; }

        override public string ToString()
        {
            return $"{TipoDemanda}";
        }
    }
}
