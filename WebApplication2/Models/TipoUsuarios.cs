using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TipoUsuarios
    {
        public TipoUsuarios()
        {
            Cuentas = new HashSet<Cuentas>();
        }

        public short IdUsuario { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cuentas> Cuentas { get; set; }
    }
}
