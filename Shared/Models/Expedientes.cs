using ProyectFinal.Data;
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
        [ForeignKey("Sentencias")]
        public int SentenciaId { get; set; }
        [ForeignKey("Users")]
        public string Id { get; set; }
        [ForeignKey("Demandas")]
        public int DemandaId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Comentario { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaCreacion { get; set; }

   

    }
}
