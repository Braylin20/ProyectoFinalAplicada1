﻿using Microsoft.AspNetCore.Identity;
using ProyectFinal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class Demandas
    {
        [Key]
        public int DemandaId { get; set; }
        public int? TiposDemandasId { get; set; }
        public int? EstadoId { get; set; }
        public int? AlguacilId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "La cédula debe tener 11 digitos")]
        public long? Cedula { get; set; }
        public int? AudienciaId { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        public byte[]? Documento { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public byte[]? FotoCedula { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }

        public Sentencias? Sentencias { get; set; }

        [ForeignKey("EstadoId")]
        public EstadosDemandas? EstadoDemanda { get; set; }
        [ForeignKey("TiposDemandasId")]
        public TiposDemandas? TipoDemanda { get; set; }
        [ForeignKey("AlguacilId")]
        public Alguaciles? Alguacil { get; set; }
        [ForeignKey("AudienciaId")]
        public Audiencias? Audiencia { get; set; }

        [ForeignKey("DemandaId")]
        public ICollection<DemandasDetalle> DemandaDetalles { get; set; } = new List<DemandasDetalle>();

        [ForeignKey("DemandaId")]
        public ICollection<NinoDetalle> UsuarioNinoDetalles { get; set; } = new List<NinoDetalle>();
    }
}
