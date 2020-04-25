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
    }
}
