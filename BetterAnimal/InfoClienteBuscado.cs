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
    public partial class InfoClienteBuscado : Form
    {
        public static int dni = 2; //el id del usuario yo que se lo que marca que usuario buscaste.
        public InfoClienteBuscado()
        {
            InitializeComponent();
        }
        public void enseñaCliente(int id)
        {
            /* Este metodo reduce la cantidad de codigo de los botones permitiendo agrupar todo en el mismo.
             * Este metodo lee el Id Actual y muestra la info del mismo pokemon con esa id.(Alvaro)
             */
            //misPokemons = miConexion.getPokemonPorId(id);
            //nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            
        }
    }
}
