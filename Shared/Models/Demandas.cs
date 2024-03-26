using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Demandas
    {
        [Key]
        public int DemandaId { get; set; }
        public int TiposDemandasId { get; set; }
        public int EstadoId { get; set; }
        public int AlguacilId { get; set; }
        public int AudienciaId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }
        [ForeignKey("EstadoId")]
        public EstadosDemandas? EstadoDemanda { get; set; }
        [ForeignKey("TiposDemandasId")]
        public TiposDemandas? TipoDemanda { get; set; }
        [ForeignKey("AlguacilId")]
        public Alguaciles? Alguacil { get; set; }
        [ForeignKey("AudienciaId")]
        public Audiencias? Audiencia { get; set; }
        //[ForeignKey("DemandaId")]
        //public ICollection<Audiencias> Audiencias { get; set; } = new List<Audiencias>();
        [ForeignKey("DemandaId")]
        public ICollection<ExpedienteDetalle> Demandados { get; set; } = new List<ExpedienteDetalle>();

        
    }
}
