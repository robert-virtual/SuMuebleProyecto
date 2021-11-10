﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuMueble.Models
{
    [Table("Pagos")]
    public class Pago
    {
        [Key] // espesifica la llave primaria en al tabla
        public int PagoId { get; set; }

        [ForeignKey("Colaborador")]
        public string ColaboradorDNI { get; set; }
        public Colaborador Colaborador { get; set; }

        [ForeignKey("Venta")]
        public int CodigoFactura { get; set; }
        public Venta Venta { get; set; }
        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; }

        public Pago()
        {
            Fecha = DateTime.Now;
        }
    }
}
