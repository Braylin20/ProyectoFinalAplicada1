using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Sentencias
    {
        [Key]
        public int SentenciaId { get; set; }
        public int ResolucionId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? NombreMinisterio { get; set; }
        [ForeignKey("ResolucionId")]
        public TipoResoluciones TipoResoluciones { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaCreacion { get; set; }
        

    }
}
