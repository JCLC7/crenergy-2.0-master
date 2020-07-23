using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class AltaAnuncio
    {
        public string Imagen { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }

       
        public int IdCategoria { get; set; }

   
        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public string Ubicacion { get; set; }

    }
}
