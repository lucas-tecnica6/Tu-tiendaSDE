namespace TuTiendaSDE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consulta")]
    public partial class Consulta
    {
        public int ConsultaID { get; set; }

        public int ProductoID { get; set; }

        public bool Disponibilidad { get; set; }

        [Column(TypeName = "money")]
        public decimal Precio { get; set; }

        public DateTime fecha { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
