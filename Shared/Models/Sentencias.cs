﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class Sentencias
    {
        [Key]
        public int SentenciaId { get; set; }
        public int? DemandaId { get; set; }
        public int ResolucionId { get; set; }
        public byte[]? Sentencia { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? NombreMinisterio { get; set; }
        [ForeignKey("ResolucionId")]
        public TipoResoluciones TipoResoluciones { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaCreacion { get; set; }
        [ForeignKey("DemandaId")]
        public Demandas? Demandas { get; set; }
        

    }
}
