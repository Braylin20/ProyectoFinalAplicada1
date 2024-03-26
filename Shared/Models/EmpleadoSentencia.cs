using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared1.Models
{
    public class EmpleadoSentencia
    {
        [Key]
        public int EmpleadoSentenciaId { get; set; }
        public int SentenciaId { get; set; }
        public int EmpleadoId { get; set; }
        [ForeignKey("SentenciaId")]
        public Sentencias? Sentencia { get; set; }
        [ForeignKey("EmpleadoId")]
        public Empleados? Empleado { get; set; }
    }
}
