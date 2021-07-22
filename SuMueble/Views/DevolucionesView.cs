﻿using SuMueble.Controller;
using SuMueble.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SuMueble.Views
{
    public partial class DevolucionesView : UserControl
    {
        VentaController ventaController = new VentaController();
        IEnumerable<Ventas> ListaVentas;
        List<Ventas> ventas;
        public DevolucionesView()
        {
            InitializeComponent();
            ListaVentas = ventaController.ObtenerVenta();
            dvg_devoluciones.AutoGenerateColumns = false;
            dvg_devoluciones.DataSource = ListaVentas;
            ventas = ventaController.ObtenerVenta().ToList();
            dvg_devoluciones.DataSource = ventas;


        }

        private void btn_agregarDevolucion_Click(object sender, EventArgs e)
        {
            Devolucion devolucion = new Devolucion();
            devolucion.ShowDialog();
        }

        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscarCliente_TextChanged_1(object sender, EventArgs e)
        {
            string buscar = txt_buscarCliente.Text.ToLower();

            List<Ventas> filtrados = ventas.Where<Ventas>(x => {

                return x.NombreCliente.ToLower().StartsWith(buscar);


            }).ToList();

            dvg_devoluciones.DataSource = null;
            dvg_devoluciones.DataSource = filtrados;
        }
    }
}
