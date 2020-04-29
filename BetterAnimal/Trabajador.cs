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
        DataTable mascotaPorChip = new DataTable();
        DataTable chips = new DataTable();

        string dni;
        string chip;
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
            //Tabla Revisiones
            dataGridRevision.DataSource = conexion.getRevision();
            dataGridRevision.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridRevision.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //Tabla Vacunas
            dataGridVacunas.DataSource = conexion.getVacunas();
            dataGridVacunas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridVacunas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //Tabla Peluqueria
            dataGridPelo.DataSource = conexion.getPeluqueria();
            dataGridPelo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridPelo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void buscarCliente(object sender, EventArgs e)
        {
           //lee lo que escribes en la TexBox y lo compara con la BBDD si coincide mostrara la info del cliente.
            String dniCliente = textBox1.Text;
            clientePorDNI = conexion.getClientePorDNI(dniCliente);
            if (clientePorDNI.Rows.Count == 0)
            {
                label2.Text = "Error, escribe el DNI correctamente.";
            }
            else
            {
                //InfoClienteBuscado.dni = int.Parse(mascotaPorChip.Rows[0]["dni_cliente"].ToString());
                InfoClienteBuscado.DNIactual = int.Parse(clientePorDNI.Rows[0]["dni_cliente"].ToString());
                InfoClienteBuscado ventana = new InfoClienteBuscado();
                ventana.Show();
                this.Hide();
               

            }

        }
        private void buscarMascota(object sender, EventArgs e)
        {
            //lee lo que escribes en la TexBox y lo compara con la BBDD si coincide mostrara la info del animal.
            String chipMascota = textBox2.Text;
            mascotaPorChip = conexion.getAnimalPorChip(chipMascota);
            if (mascotaPorChip.Rows.Count == 0)
            {
                label4.Text = "Error, escribe el Chip correctamente.";
            }
            else
            {

                // VentanaPrincipal.idActual = int.Parse(clienteporDNI.Rows[0]["dni_cliente"].ToString());
                // this.mainForm.enseñaPokemon(VentanaPrincipal.idActual);
                //InfoClienteBuscado.dni =  int.Parse(mascotaPorChip.Rows[0]["chip_mascota"].ToString());
                VentanaCliente ventana = new VentanaCliente();
                ventana.Show();
                this.Hide();

            }
        }

        private void registrarMascota(object sender, EventArgs e)
        {
            VentanaRegistarMascota ventana = new VentanaRegistarMascota();
            ventana.Show();
          
        }

        private void registrarTrabajador(object sender, EventArgs e)
        {
            VentanaRegistarTrabajador ventana = new VentanaRegistarTrabajador();
            ventana.Show();
           
        }

        private void registrarCliente(object sender, EventArgs e)
        {
            VentanaRegistarUsuario ventana = new VentanaRegistarUsuario();
            ventana.Show();
            
        }

        private void dataGridMascotas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chip = dataGridMascotas.Rows[e.RowIndex].Cells["chip_mascota"].Value.ToString();
            MessageBox.Show(chip);
        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            dni = dataGridMascotas.Rows[e.RowIndex].Cells["dni_cliente"].Value.ToString();
            MessageBox.Show(chip);
            InfoClienteBuscado ventana = new InfoClienteBuscado();
            ventana.Show();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            chips = conexion.getAllClientes(chip);
           // labelNombre.Text = "Nombre" + chips.Rows[1]["nombre_cliente"].ToString();

        }

        private void botonRegistrarVacuna(object sender, EventArgs e)
        {
            Citas.RegistarVacuna ventana = new Citas.RegistarVacuna();
            ventana.Show();
                    
        }

        private void botonRegistrarPeluqueria(object sender, EventArgs e)
        {
            Citas.RegistrarPeluqueria ventana = new Citas.RegistrarPeluqueria();
            ventana.Show();
        }

        private void botonRegistrarRevision(object sender, EventArgs e)
        {
            Citas.RegistrarRevision ventana = new Citas.RegistrarRevision();
            ventana.Show();
        }
    }
}
