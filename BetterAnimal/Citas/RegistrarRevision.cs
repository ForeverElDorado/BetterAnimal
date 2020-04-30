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
    public partial class RegistrarRevision : Form
    {
        Conexion conexion = new Conexion();
        public RegistrarRevision()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaRevision(textBoxChip.Text, dateTimePicker1.Value, textBoxMotivo.Text));
        }
    }
}
