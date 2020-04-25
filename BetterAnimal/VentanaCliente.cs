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
    }
}
