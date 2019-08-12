namespace TuTiendaSDE.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class PpsContext : DbContext
	{
		public PpsContext()
			: base("name=PpsContext")
		{
		}

		public virtual DbSet<Consulta> Consulta { get; set; }
		public virtual DbSet<Producto> Producto { get; set; }
		public virtual DbSet<Tienda> Tienda { get; set; }
		public virtual DbSet<TiendaProducto> TiendaProducto { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Consulta>()
				.Property(e => e.Precio)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Producto>()
				.Property(e => e.Nombre)
				.IsUnicode(false);

			modelBuilder.Entity<Producto>()
				.Property(e => e.Marca)
				.IsUnicode(false);

			modelBuilder.Entity<Producto>()
				.Property(e => e.Precio)
				.HasPrecision(8, 2);

			modelBuilder.Entity<Producto>()
				.HasMany(e => e.Consulta)
				.WithRequired(e => e.Producto)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Producto>()
				.HasMany(e => e.TiendaProducto)
				.WithRequired(e => e.Producto)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Tienda>()
				.Property(e => e.Nombre)
				.IsUnicode(false);

			modelBuilder.Entity<Tienda>()
				.Property(e => e.Direccion)
				.IsUnicode(false);

			modelBuilder.Entity<Tienda>()
				.Property(e => e.Telefono)
				.IsUnicode(false);

			modelBuilder.Entity<Tienda>()
				.HasMany(e => e.TiendaProducto)
				.WithRequired(e => e.Tienda)
				.WillCascadeOnDelete(false);
		}
	}
}
