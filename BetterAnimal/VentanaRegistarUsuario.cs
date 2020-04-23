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
    public partial class VentanaRegistarUsuario : Form
    {
        Conexion conexion = new Conexion();
        public VentanaRegistarUsuario()
        {
            InitializeComponent();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            //El textbox apellidos tiene que ser el pass pero nose a que hace referencia en nuestra base de datos. Si a contraseña O password.
            //En esta parte del codigo tienes que añadir un textbox por cada strin que se coloque en insertaUsuario de la clase de conexion.
            //En nuestro caso seria cada campo que hay en el diseño, todos los textbox ya tienen nombre añadido para se implementados a continuacion.

            String textoContraseña = textBoxContraseña.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textoContraseña, BCrypt.Net.BCrypt.GenerateSalt());

            //Para las pruebas de insertar usar este:
            //MessageBox.Show(conexion.insertaUsuario(textBoxDNI.Text, textBoxNombre.Text, myHash));

            MessageBox.Show(conexion.insertaCliente(textBoxDNI.Text, textBoxNombre.Text, textBoxApellidos.Text, textBoxTlf.Text, textBoxChip.Text, textBoxEmail.Text, textBoxUsuario.Text, myHash));
            //En herramientas nugget añadir el siguiente comando para la encriptacion de contraseñas
            // Install-Package BCrypt-Official
            //Si registrais a alguien porfavor apuntar la contraseña ya que con el Hash esta se queda encriptada.
        }
    }
}
