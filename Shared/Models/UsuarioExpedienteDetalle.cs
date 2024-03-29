using ProyectFinal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Share.Models
{
    public class UsuarioExpedienteDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        [ForeignKey("Id")]
        public ApplicationUser User { get; set; }
        [ForeignKey("ExpedienteId")]
        public Expedientes Expediente { get; set; }
    }
}
