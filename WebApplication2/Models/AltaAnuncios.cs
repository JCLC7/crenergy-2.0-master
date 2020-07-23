using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class AltaAnuncios
    {
        public short IdAnuncio { get; set; }
        public short? IdCategoria { get; set; }
        public short? IdImagenAnuncio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float? Precio { get; set; }
        public string Ubicacion { get; set; }

        public virtual TipoCategorias IdCategoriaNavigation { get; set; }
        public virtual ImagenesAnuncios IdImagenAnuncioNavigation { get; set; }
    }
}
