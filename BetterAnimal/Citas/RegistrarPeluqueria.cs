using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterAnimal.Citas
{
    public partial class RegistrarPeluqueria : Form
    {
        Conexion conexion = new Conexion();
        public RegistrarPeluqueria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaPeluqueria(textBoxChip.Text, dateTimePicker1.Value,textBoxTratamiento.Text));
        }
    }
}
