using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("TiposVenta")]
    public class TipoVenta
    {
        [Key]
        public int TipoVentaId { get; set; }

        [Required,MaxLength(25)]
        public string Nombre { get; set; }

        public List<Venta> Ventas { get; set; }
        public override string ToString() => Nombre;

        public TipoVenta()
        {
            Ventas = new List<Venta>();
        }

    }
}
