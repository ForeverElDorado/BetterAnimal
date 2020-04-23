using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace BetterAnimal
{
    public partial class VentanaRegistarTrabajador : Form
    {
        Conexion conexion = new Conexion();
        public VentanaRegistarTrabajador()
        {
            InitializeComponent();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
           //referente a la tabla trabajador

            String textoContraseña = textBoxContraseña.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoContraseña, BCrypt.Net.BCrypt.GenerateSalt());

            MessageBox.Show(conexion.insertaTrabajador(textBoxDNI.Text, textBoxNombre.Text, textBoxApellidos.Text, textBoxTlf.Text, textBoxEmail.Text, textBoxUsuario.Text, myHash));
         
        }
    }
}
