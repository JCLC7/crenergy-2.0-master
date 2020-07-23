using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TipoCategorias
    {
        public TipoCategorias()
        {
            AltaAnuncios = new HashSet<AltaAnuncios>();
        }

        public short IdCategoria { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<AltaAnuncios> AltaAnuncios { get; set; }


        /*
         private static void AdministrarCategorias()
        {               
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1. Alta de categoria");
            Console.WriteLine("2. Edicion de categoria");
            Console.WriteLine("3. Baja de categoria");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    Console.WriteLine("Ingrese información"); 
                    TipoCategoria NuevaCategoria = new TipoCategoria();                  
                    Console.Write("Nombre de la categoria: ");
                    NuevaCategoria.Nombre = Console.ReadLine();
                    Console.WriteLine("Se añadió el producto correctamente");
                    AltaCategoria(NuevaCategoria);
                    break;
                case "2":
                    VerCategorias();
                    Console.WriteLine("Ingrese id de la categoria a editar");                   
                    int IdProductos = int.Parse(Console.ReadLine());
                    TipoCategorias EditarCategoria = new TipoCategorias();
                    EditarCategoria.IdCategoria = IdCategoria;
                    Console.Write("Nuevo nombre de la categoria: ");
                    EditarProducto.Nombre = Console.ReadLine();
                    Console.WriteLine("Se editó el producto correctamente");
                    EditCategoria(EditarCategoria);
                    break;
                case "3":
                    VerProductos();
                    TipoCategorias EliminarCategoria = new TipoCategorias();
                    Console.WriteLine("Ingrese id de la categoria a eliminar");
                    EliminarCategoria.IdCategoria = int.Parse(Console.ReadLine());
                    ElimCategoria(EliminarCategoria);
                    Console.WriteLine("Se eliminó el producto correctamente");
                    break;
            }
        }
        
        */


        private static void AltaCategoria(TipoCategorias NuevaCategoria)
        {
            using (var context = new wEservicesContext())
            {
                context.TipoCategorias.Add(NuevaCategoria);
                context.SaveChanges();
            }
        }


        private static void EditCategoria(TipoCategorias EditarCategoria)
        {
            try
            {
                using (var context = new wEservicesContext())
                {
                    context.TipoCategorias.Update(EditarCategoria);
                    context.SaveChanges();
                }
            }
            catch
            {
                Console.Write("Ocurrio un error al modificar");
                Console.ReadLine();
            }

        }

        private static void ElimCategoria(TipoCategorias EliminarCategoria)
        {
            try
            {
                using (var context = new wEservicesContext())
                {
                    context.TipoCategorias.Remove(EliminarCategoria);
                    context.SaveChanges();
                }
            }
            catch
            {
                Console.Write("Ocurrio un error al eliminar");
                Console.ReadLine();
            }
        }

    }
}
