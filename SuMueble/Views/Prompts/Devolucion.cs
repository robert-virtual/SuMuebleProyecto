﻿using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{

    public partial class Devolucion : Form
    {
        DevolucionControlador devolucionControlador = new DevolucionControlador();
        DetalleVentaController dvControllador = new DetalleVentaController();
        List<SQLViewVentas> detalles_;
        public Devolucion(Guid IDVenta_)
        {
            InitializeComponent();
            
            cargarDatos(IDVenta_);
        }

        private void cargarDatos(Guid IDVenta)
        {
            detalles_ = dvControllador.GetDetalles(IDVenta);
            cb_productos.DataSource = detalles_;
            cb_productos.DisplayMember = "Producto";
            cb_productos.ValueMember = "IDProducto";

            //
            txt_CodigoFactura.Text = detalles_[0].CodigoFactura.ToString();
        }

        private void btn_hecho_Click(object sender, EventArgs e)
        {
            Devoluciones devolucion = new Devoluciones()
            {
                CodigoFactura = detalles_[0].CodigoFactura,
                Cantidad = int.Parse(txt_Cantidad.Text),
                IDProducto = cb_productos.SelectedValue.GetHashCode(),
                Motivo= txt_Motivo.Text,
                Observaciones= txt_Observacion.Text

            };
            var res = devolucionControlador.InsertarDevolucion(devolucion);
            if (res > 0)
                MessageBox.Show("Devolucion Guardada Corrrecta Mente","Devoluciones",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("La Devolucion NO se Guardo Corrrecta Mente", "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
        }

        private void cb_productos_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_productos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_Cantidad.Text = detalles_.Find(x => x.IDProducto == cb_productos.SelectedValue.GetHashCode()).Cantidad.ToString();

        }
    }
}
