using Microsoft.AspNetCore.Identity;
using Share.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectFinal.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //public int? ExpedienteId { get; set; }
        public int? AbogadoId { get; set; }
        public long? Cedula { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public long Telefono { get; set; }
        //[ForeignKey("ExpedienteId")]
        //public Expedientes? Exepediente { get; set; }
        [ForeignKey("AbogadoId")]
        public UsuarioDetalle? Abogado { get; set; }
        //[ForeignKey("NinoId")]
        //public Niños? Niño { get; set; }
        [ForeignKey("Id")]
        public ICollection<UsuarioDetalle> UsuarioDetalle { get; set; } = new List<UsuarioDetalle>();
        

    }

}
