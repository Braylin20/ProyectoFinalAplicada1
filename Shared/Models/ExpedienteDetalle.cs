using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class ExpedienteDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        public int DemandaId { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
    }
}
