using Microsoft.AspNetCore.Identity;
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
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }






    }
}
