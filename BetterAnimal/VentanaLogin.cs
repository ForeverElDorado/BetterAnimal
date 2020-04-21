﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterAnimal
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();

        public VentanaLogin()
        {
            InitializeComponent();
        }

        
        private void botonHacerLogin(object sender, EventArgs e)
        {
            //this.Hide();
            //VentanaInicio v = new VentanaInicio();
            //v.Show();

            if (conexion.loginVeterinario(textBoxUsuario.Text, textBoxContraseña.Text))
            {
                this.Hide();
                VentanaInicio v = new VentanaInicio();
                v.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña erroneos");
            }

            //  String resultado = conexion.loginVeterinario(textBoxUsuario.Text, textBoxContraseña.Text);
            // MessageBox.Show(resultado);
            //VentanaInicio v = new VentanaInicio();
            //v.Show();
        }
    }
}
