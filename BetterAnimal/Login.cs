using System;
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
    public partial class Login : Form
    {
        Conexion conexion = new Conexion();

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(conexion.loginVeterinario(textBoxUsuario.Text, textBoxContraseña.Text))
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
