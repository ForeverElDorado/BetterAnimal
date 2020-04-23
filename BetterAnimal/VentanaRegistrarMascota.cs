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
    public partial class VentanaRegistarMascota : Form
    {
        Conexion conexion = new Conexion();
        public VentanaRegistarMascota()
        {
            InitializeComponent();
        }
        private void buttonRegistrarPet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaMascota(textBoxNacimietoPet.Text, textBoxNombrePet.Text, textBoxRazaPet.Text, textBoxTrabajador, textBoxChip));

        }
    }
}
