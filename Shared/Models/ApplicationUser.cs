using Microsoft.AspNetCore.Identity;
using Shared.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectFinal.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int? ExpedienteId { get; set; }
       // public int AbogadoId { get; set; }
        public int? NinoId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public long Telefono { get; set; }
        [ForeignKey("ExpedienteId")]
        public Expedientes? Exepediente { get; set; }
        //[ForeignKey("AbogadoId")]
        //public Abogados? Abogado { get; set; }
        [ForeignKey("NinoId")]
        public Ni�os? Ni�o { get; set; }


       
    }

}
