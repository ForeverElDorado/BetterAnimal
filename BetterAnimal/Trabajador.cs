using MySql.Data.MySqlClient.Memcached;
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
        ///
        DataTable clientes = new DataTable();

        DataTable clientePorDNI = new DataTable();
        DataTable mascotaPorChip = new DataTable();
        
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
        //Buscadores
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
                cogerInfo(dniCliente);
                MessageBox.Show("Cliente buscado, vaya a la hoja de resultados.");

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
                cogerInfoMascota(chipMascota);
                MessageBox.Show("Mascota buscada, vaya a la hoja de resultados.");
            }
        }
        //Registros
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
        //PARA EL BUSCADOR DE PINCHAR
        private void dataGridMascotas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cogerInfoMascota(dataGridMascotas.Rows[e.RowIndex].Cells["chip_mascota"].Value.ToString());
            MessageBox.Show("Mascota buscada, vaya a la hoja de resultados.");
        }
        private void dataGridClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cogerInfo(dataGridClientes.Rows[e.RowIndex].Cells["dni_cliente"].Value.ToString());
            MessageBox.Show("Cliente buscado, vaya a la hoja de resultados.");
        }
        
        public void cogerInfo(String dni)
        {
            clientes = conexion.getAllClientes(dni);
            labelNombre.Text = "Nombre: " + clientes.Rows[0]["nombre_cliente"].ToString();
            labelApellidos.Text = "Primer Apellido: " + clientes.Rows[0]["apellido_cliente"].ToString();
            labelTelefono.Text = "Telefono: " + clientes.Rows[0]["telefono"].ToString();
            labelEmail.Text = "Email: " + clientes.Rows[0]["email"].ToString();
            labelDNI.Text = "DNI: " + clientes.Rows[0]["dni_cliente"].ToString();
        }
        public void cogerInfoMascota(String chip)
        {
            mascotas = conexion.getAllMascotas(chip);
            labelChip_mascota.Text = "Chip: " + mascotas.Rows[0]["chip_mascota"].ToString();
            labelDNI_mascota.Text = "DNI Cliente: " + mascotas.Rows[0]["dni_cliente"].ToString();
            labelNombre_Trabajador.Text = "Trabajador: " + mascotas.Rows[0]["nombre_trabajador"].ToString();
            labelRaza.Text = "Raza: " + mascotas.Rows[0]["raza_mascota"].ToString();
            labelFechaNa.Text = "Fecha NA: " + mascotas.Rows[0]["fecha_na_mascota"].ToString();
            labelNombre_mascota.Text = "Nombre Animal: " + mascotas.Rows[0]["nombre_mascota"].ToString();
        }



        private void tabControl1_Enter(object sender, EventArgs e)
        {
           // chips = conexion.getAllClientes(chip);
           // labelNombre.Text = "Nombre" + chips.Rows[1]["nombre_cliente"].ToString();

        }
        //REGISTRO DE CITAS...
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
