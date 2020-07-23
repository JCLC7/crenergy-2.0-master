using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Cuentas
    {
        public short IdCuenta { get; set; }
        public short? IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public byte? ConEmpresa { get; set; }
        public byte? SinEmpresa { get; set; }
        public byte? TerminosCondiciones { get; set; }

        public virtual TipoUsuarios IdUsuarioNavigation { get; set; }
    }
}
