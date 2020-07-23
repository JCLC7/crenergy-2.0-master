using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TipoImagenes
    {
        public TipoImagenes()
        {
            ImagenesAnuncios = new HashSet<ImagenesAnuncios>();
        }

        public short IdTipoImagen { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ImagenesAnuncios> ImagenesAnuncios { get; set; }
    }
}
