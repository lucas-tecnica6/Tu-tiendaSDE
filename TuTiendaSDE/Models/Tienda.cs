namespace TuTiendaSDE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tienda")]
    public partial class Tienda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tienda()
        {
            TiendaProducto = new HashSet<TiendaProducto>();
        }

        public int TiendaID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }

        public TimeSpan? HorarioDesde { get; set; }

        public TimeSpan? HorarioHasta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiendaProducto> TiendaProducto { get; set; }
    }
}
