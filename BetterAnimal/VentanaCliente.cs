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
        DataTable tienda = new DataTable();

        DataTable cliente = new DataTable();

        public VentanaCliente()
        {
            InitializeComponent();
            //LA TABLA NO FUNCIONA BIEN MEJOR COMENTARLA Y EVITAR ERRORES AL AÑADIR NUEVAS MASCOTAS
            //tablaMascotas.DataSource = conexion.getMisMascotas();
            //tablaMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //tablaMascotas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTienda.DataSource = conexion.getTienda();
            dataGridTienda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridTienda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            conexion.getMisDatos();

            cliente = conexion.getMisDatos();
            labelNombre.Text = "Nombre: " + cliente.Rows[0]["nombre_cliente"].ToString();
            labelApellidos.Text = "Primer Apellido: " + cliente.Rows[0]["apellido_cliente"].ToString();
            labelTelefono.Text = "Telefono: " + cliente.Rows[0]["telefono"].ToString();
            labelEmail.Text = "Email: " + cliente.Rows[0]["email"].ToString();
            labelDNI.Text = "DNI: " + cliente.Rows[0]["dni_cliente"].ToString();

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
