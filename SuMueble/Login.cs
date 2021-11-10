﻿using SuMueble.DataAccess;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuMueble.Views
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            var res = SeedData.CheckDefaultColaborador();
            Text = res ? "dynamic title" : "res es false";
            string user = txt_user.Text;
            string password = txt_password.Text;
            var colaborador = new Colaborador();
                using (var db = new SuMuebleDBContext())
                {
                    try
                    {
                        colaborador = db.Colaboradores.Find(user);
                    }
                    catch (DbEntityValidationException err)
                    {

                        VentaCreditoView.showValidationError(err);
                    }
                }

            if (colaborador != null)
                {

                    if (colaborador.Activo)
                    {
                        if (colaborador.Clave == password)
                        {
                            Menu menu = new Menu(colaborador);
                            menu.Show();
                            this.Hide();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Colaborador inhabilitado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                    MessageBox.Show("Codigo o Clave de Usuario Invalido", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_user.Text = "";
                txt_password.Text = "";
                txt_user.Focus();
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_verContrasena.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else {
                txt_password.PasswordChar = '●';
            }
        }
    }
}
