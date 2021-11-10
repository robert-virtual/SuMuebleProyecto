﻿using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ventana_de_Inventarios;

namespace SuMueble.Views
{
    public partial class Menu : Form
    {
        public static Colaborador colaborador;
        public Menu( Colaborador colaborador_ )
        {
            InitializeComponent();
            colaborador = colaborador_;
            VentaView ventasUc = new VentaView();
            contenedor.Controls.Add(ventasUc);
            ValidarRol();
            bienvenido.Text = string.Format("{0}",colaborador_.Nombre);

        }
        private void ValidarRol() 
        {
            // venta
            if (colaborador.PuestoId == 2)
            {
                btn_inventario.Visible = false;
                btn_colaboradores.Visible = false;
            }

            // bodega
            if (colaborador.PuestoId == 3)
            {
                btn_ventas.Visible = false;
                btn_ventasCredito.Visible = false;
                btn_creditos.Visible = false;
                btn_devoluciones.Visible = false;
                btn_colaboradores.Visible = false;
            }
            // secretaria
            if (colaborador.PuestoId == 4)
            {
                btn_inventario.Visible = false;
                btn_devoluciones.Visible = false;
                btn_ventas.Visible = false;
                btn_ventasCredito.Visible = false;
            }
            // gerente lo vee todo
            //ID = 1
            //Holi
        }
        
        private void HideAll()
        {

            btn_ventas.ForeColor = Color.FromName("ControlText");
            btn_ventas.BackColor = Color.FromName("ControlLight");
            
            btn_inventario.ForeColor = Color.FromName("ControlText");
            btn_inventario.BackColor = Color.FromName("ControlLight");
            
            btn_creditos.ForeColor = Color.FromName("ControlText");
            btn_creditos.BackColor = Color.FromName("ControlLight");
            
            btn_devoluciones.ForeColor = Color.FromName("ControlText");
            btn_devoluciones.BackColor = Color.FromName("ControlLight");
            
            btn_historialVentas.ForeColor = Color.FromName("ControlText");
            btn_historialVentas.BackColor = Color.FromName("ControlLight");

            btn_colaboradores.ForeColor = Color.FromName("ControlText");
            btn_colaboradores.BackColor = Color.FromName("ControlLight");

            btn_ventasCredito.ForeColor = Color.FromName("ControlText");
            btn_ventasCredito.BackColor = Color.FromName("ControlLight");



        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            // quita el color del bton seleccionado antes
            HideAll();
            // establece el color de selccionado de la letra
            btn_ventas.ForeColor = Color.White;
            // establece el color de selccionado
            btn_ventas.BackColor = Color.DodgerBlue;
            //UserControl
            contenedor.Controls.Clear();
            VentaView ventasUc = new VentaView();
            //ventasUc.Width = panel2.Width-5;
            //ventasUc.Height = panel2.Height-5;
            contenedor.Controls.Add(ventasUc);
            

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_inventario.ForeColor = Color.White;
            btn_inventario.BackColor = Color.DodgerBlue;
            contenedor.Controls.Clear();
            // vista
            InventariosView inventario = new InventariosView();
            contenedor.Controls.Add(inventario);
        }
    

        private void btn_creditos_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_creditos.ForeColor = Color.White;
            btn_creditos.BackColor = Color.DodgerBlue;
            contenedor.Controls.Clear();
            // vista
            CreditosView creditos = new CreditosView();
            contenedor.Controls.Add(creditos);
        }

        private void btn_devoluciones_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_devoluciones.ForeColor = Color.White;
            btn_devoluciones.BackColor = Color.DodgerBlue;
            contenedor.Controls.Clear();
            // vista
            DevolucionesView devoluciones = new DevolucionesView();
            contenedor.Controls.Add(devoluciones);
        }

        private void btn_historialVentas_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_historialVentas.ForeColor = Color.White;
            btn_historialVentas.BackColor = Color.DodgerBlue;
            
            // vista
            contenedor.Controls.Clear();
            HistorialVentasView historial = new HistorialVentasView();
            contenedor.Controls.Add(historial);
        }

        private void btn_colaboradores_Click(object sender, EventArgs e)
        {
            HideAll();
            btn_colaboradores.ForeColor = Color.White;
            btn_colaboradores.BackColor = Color.DodgerBlue;
            contenedor.Controls.Clear();
            ColaboradoresView uc = new ColaboradoresView();
            contenedor.Controls.Add(uc);
        }

        

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Application.Exit();

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btn_ventasCredito_Click(object sender, EventArgs e)
        {
            HideAll();

            btn_ventasCredito.ForeColor = Color.White;
            btn_ventasCredito.BackColor = Color.DodgerBlue;
            contenedor.Controls.Clear();
            VentaCreditoView ventaCreditoView = new VentaCreditoView();
            contenedor.Controls.Add(ventaCreditoView);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            HideAll();

            btn_clientes.ForeColor = Color.White; // color blanco texto boton
            btn_clientes.BackColor = Color.DodgerBlue; // color azul de boton seleccionado
            contenedor.Controls.Clear();
            var clientesView = new ClientesView();
            contenedor.Controls.Add(clientesView);
        }
    }
}
