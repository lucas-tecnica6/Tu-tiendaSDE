namespace TuTiendaSDE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiendaProducto")]
    public partial class TiendaProducto
    {
        [Key]
        public int ProTiendaID { get; set; }

        public int TiendaID { get; set; }

        public int ProductoID { get; set; }

        public int Disponibilidad { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Tienda Tienda { get; set; }
    }
}
