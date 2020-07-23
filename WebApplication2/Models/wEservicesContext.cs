using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class wEservicesContext : DbContext
    {
        public wEservicesContext()
        {
        }

        public wEservicesContext(DbContextOptions<wEservicesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AltaAnuncios> AltaAnuncios { get; set; }
        public virtual DbSet<Cuentas> Cuentas { get; set; }
        public virtual DbSet<ImagenesAnuncios> ImagenesAnuncios { get; set; }
        public virtual DbSet<TipoCategorias> TipoCategorias { get; set; }
        public virtual DbSet<TipoImagenes> TipoImagenes { get; set; }
        public virtual DbSet<TipoUsuarios> TipoUsuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;database=wEservices;user id=root;password=GZ5x43aD;port=3306");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AltaAnuncios>(entity =>
            {
                entity.HasKey(e => e.IdAnuncio)
                    .HasName("PRIMARY");

                entity.ToTable("alta_anuncios");

                entity.HasIndex(e => e.IdCategoria)
                    .HasName("IdCategoria");

                entity.HasIndex(e => e.IdImagenAnuncio)
                    .HasName("IdImagen_Anuncio");

                entity.Property(e => e.IdImagenAnuncio).HasColumnName("IdImagen_Anuncio");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.AltaAnuncios)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("alta_anuncios_ibfk_1");

                entity.HasOne(d => d.IdImagenAnuncioNavigation)
                    .WithMany(p => p.AltaAnuncios)
                    .HasForeignKey(d => d.IdImagenAnuncio)
                    .HasConstraintName("alta_anuncios_ibfk_2");
            });

            modelBuilder.Entity<Cuentas>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                    .HasName("PRIMARY");

                entity.ToTable("cuentas");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("Id_Usuario");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConEmpresa).HasColumnType("tinyint(1)");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SinEmpresa).HasColumnType("tinyint(1)");

                entity.Property(e => e.TerminosCondiciones)
                    .HasColumnName("terminosCondiciones")
                    .HasColumnType("tinyint(1)");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cuentas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("cuentas_ibfk_1");
            });

            modelBuilder.Entity<ImagenesAnuncios>(entity =>
            {
                entity.HasKey(e => e.IdImagenAnuncio)
                    .HasName("PRIMARY");

                entity.ToTable("imagenes_anuncios");

                entity.HasIndex(e => e.IdTipoImagen)
                    .HasName("Id_TipoImagen");

                entity.Property(e => e.IdImagenAnuncio).HasColumnName("IdImagen_Anuncio");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoImagen).HasColumnName("Id_TipoImagen");

                entity.HasOne(d => d.IdTipoImagenNavigation)
                    .WithMany(p => p.ImagenesAnuncios)
                    .HasForeignKey(d => d.IdTipoImagen)
                    .HasConstraintName("imagenes_anuncios_ibfk_1");
            });

            modelBuilder.Entity<TipoCategorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_categorias");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoImagenes>(entity =>
            {
                entity.HasKey(e => e.IdTipoImagen)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_imagenes");

                entity.Property(e => e.IdTipoImagen).HasColumnName("Id_TipoImagen");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TipoUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_usuarios");

                entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
