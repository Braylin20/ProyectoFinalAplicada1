using Shared1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class Expedientes
    {
        [Key]
        public int ExpedienteId { get; set; }
        public int SentenciaId { get; set; }
        public int DemandaId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Comentario { get; set; }
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaEntrada { get; set; }

        [ForeignKey("DemandaId")]
        public Demandas? Demandas { get; set; }
        [ForeignKey("SentenciaId")]
        public Sentencias? Sentencia { get; set; }


    }
}
