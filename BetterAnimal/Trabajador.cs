using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterAnimal.Trabajador
{
    public partial class Trabajador : Form
    {
        Conexion conexion = new Conexion();
        DataTable mascotas = new DataTable();
        DataTable clientes = new DataTable();

        DataTable clientePorDNI = new DataTable();
        public Trabajador()
        {
            InitializeComponent();
            //Tabla Clientes
            dataGridClientes.DataSource = conexion.getClientes();
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //Tabla Mascotas
            dataGridMascotas.DataSource = conexion.getMascotas();
            dataGridMascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridMascotas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void buscarCliente(object sender, EventArgs e)
        {
            /* Este metodo lee el texto que se escribe en el TextBox y al pulsa el boton devuelve la info recogida del mismo en la pantalla de la pokedex.(Alvaro)
             * Si el nombre se escribe mal e muestra un mensaje que informa del error. Si la busqueda es correcta la ventana se cierra.
             */
            String dniCliente = textBox1.Text;
            clientePorDNI = conexion.getClientePorDNI(dniCliente);
            if (clientePorDNI.Rows.Count == 0)
            {
                label2.Text = "Error, escribe el DNI correctamente.";
            }
            else
            {

                // VentanaPrincipal.idActual = int.Parse(clienteporDNI.Rows[0]["dni_cliente"].ToString());
                // this.mainForm.enseñaPokemon(VentanaPrincipal.idActual);
                //VentanaCliente ventana = new VentanaCliente();
                //ventana.Show();
                //this.Hide();
                
            }

        }
    }
}
