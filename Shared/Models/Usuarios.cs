//using Microsoft.AspNetCore.Identity;
//using Shared1;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Shared.Models
//{
//    public class Usuarios :IdentityUser
//    {

//        public int ExpedienteId { get; set; }
//        //public int AbogadoId { get; set; }
//        public int NinoId { get; set; }
//        [Required(ErrorMessage = "Este campo es requerido")]
//        public int Cedula { get; set; }
//        [Required(ErrorMessage = "Este campo es requerido")]
//        public DateTime FechaCreacion { get; set; }
//        [Required(ErrorMessage = "Este campo es requerido")]
//        public long Telefono { get; set; }
//        [ForeignKey("ExpedienteId")]
//        public Expedientes? Exepediente { get; set; }
//        //[ForeignKey("AbogadoId")]
//        //public Abogados? Abogado { get; set; }
//        [ForeignKey("NinoId")]
//        public Niños? Niño { get; set; }


//        //[ForeignKey("UsuarioId")]
//        //public ICollection<Niños> Niños { get; set; } = new List<Niños>();
//        //[ForeignKey("UsuarioId")]
//        //public ICollection<Abogados> Abogados { get; set; } = new List<Abogados>();
//        //public int RolId { get; set; }
//        //[EmailAddress(ErrorMessage = "Este campo es requerido")]
//        //public string? Correo { get; set; }
//        //[Required(ErrorMessage = "Este campo es requerido")]
//        //public string? Clave { get; set; }
//        //[ForeignKey("UsuarioId")]
//        //public ICollection<Expedientes> Expedientes { get; set; } = new List<Expedientes>();
//        //[ForeignKey("RolId")]
//        //public Roles? Roles { get; set; }
//    }
//}
