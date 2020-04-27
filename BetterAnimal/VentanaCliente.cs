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
    public partial class VentanaCliente : Form
    {
        Conexion conexion = new Conexion();
        DataTable misMascotas = new DataTable();
        public VentanaCliente()
        {
            InitializeComponent();
            tablaMascotas.DataSource = conexion.getMascotas();
            tablaMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            tablaMascotas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void botonRegistrarMascota(object sender, EventArgs e)
        {
            VentanaRegistarMascota ventana = new VentanaRegistarMascota();
            ventana.Show();
         
        }

        private void botonSolicitarPeluqueria(object sender, EventArgs e)
        {
            Citas.RegistrarPeluqueria ventana = new Citas.RegistrarPeluqueria();
            ventana.Show();
           
        }

        private void botonSolicitarRevision(object sender, EventArgs e)
        {
            Citas.RegistrarRevision ventana = new Citas.RegistrarRevision();
            ventana.Show();
           
        }

        private void botonSolicitarVacuna(object sender, EventArgs e)
        {
            Citas.RegistarVacuna ventana = new Citas.RegistarVacuna();
            ventana.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaInicio ventana = new VentanaInicio();
            ventana.Show();
            Hide();
        }
    }
}
