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
    public partial class RegistarVacuna : Form
    {
        Conexion conexion = new Conexion();
        public RegistarVacuna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.insertaVacuna(textBoxChip.Text, dateEmision.Value.ToString(), datecaducidad.Value.ToString(), textNombreVacuna.Text)); ;
        }
    }
}
