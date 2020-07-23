using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Cuenta
    {
        public string Nombre { get; set; }

        [Required, StringLength(20)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password ", ErrorMessage = "la contraseña proporcionada no coincide")]
        public int RepPassword { get; set; }


        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string Estado { get; set; }

        public bool ConEmpresa { get; set; }

        public bool SinEmpresa { get; set; }

        public bool TerminosCondiciones { get; set;}

    }
}
