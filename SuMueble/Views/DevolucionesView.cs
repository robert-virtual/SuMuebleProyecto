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
        List<Devoluciones> Devoluciones = new List<Devoluciones>();
        public DevolucionesView()
        {
            InitializeComponent();
            cb_filtro.SelectedIndex = 0;
        }
        void LoadDevoluciones()
        {
            var devolucionControlador = new DevolucionControlador();

            Devoluciones = devolucionControlador.GetAll().ToList();
            LoadDGV(Devoluciones);
        }

        void LoadDGV(List<Devoluciones> devoluciones)
        {
            dvg_devoluciones.DataSource = null;
            dvg_devoluciones.DataSource = devoluciones;

        }
        private string GetCell(int cell)
        {
            if (dvg_devoluciones.Rows.Count > 0)
            {
                int index = dvg_devoluciones.CurrentRow.Index;
                return dvg_devoluciones.Rows[index].Cells[cell].Value.ToString();

            }
            else
            {
                return "0";
            }
        }
        private void btn_agregarDevolucion_Click(object sender, EventArgs e)
        {
            int idVenta = int.Parse(GetCell(0));
            if (idVenta != 0)
            {
                var Venta = new Ventas();
                Venta = Venta.Get(idVenta);
           
                Devolucion devolucion = new Devolucion(Venta);
                devolucion.ShowDialog();

            } else
            {
                MessageBox.Show("No hay ningún producto seleccionado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_buscarCliente_TextChanged_1(object sender, EventArgs e)
        {
            string buscar = txt_buscarCliente.Text.ToLower();

            var filtrados = Devoluciones.Where(devolucion => {

                var match = false;
                devolucion.DetalleDevolucion.Where(d => {

                    match = d.Motivo.ToLower().StartsWith(buscar);
                    return match;
                });
                return match;

            }).ToList();

            LoadDGV(filtrados);
        }

        private void cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoVenta = cb_filtro.Text;

            if (tipoVenta != "Todo")
            {
                var filtrados = Devoluciones.Where(devolucion =>
                {

                    //return devolucion. == tipoVenta;
                    return true;
                }).ToList();

                LoadDGV(filtrados);
            }
            else
            {
                LoadDGV(Devoluciones);
            }
        }

        private void txt_buscarCliente_Leave(object sender, EventArgs e)
        {
            txt_buscarCliente.Text = txt_buscarCliente.Text.Trim();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            var manual = new Manual("devoluciones");
            manual.Show();
        }
    }
}
