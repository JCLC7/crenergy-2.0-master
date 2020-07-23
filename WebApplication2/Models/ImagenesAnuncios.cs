using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ImagenesAnuncios
    {
        public ImagenesAnuncios()
        {
            AltaAnuncios = new HashSet<AltaAnuncios>();
        }

        public short IdImagenAnuncio { get; set; }
        public short? IdTipoImagen { get; set; }
        public string Descripcion { get; set; }

        public virtual TipoImagenes IdTipoImagenNavigation { get; set; }
        public virtual ICollection<AltaAnuncios> AltaAnuncios { get; set; }
    }
}
