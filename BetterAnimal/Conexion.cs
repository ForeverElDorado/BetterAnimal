using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BetterAnimal
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");
        }

        public String loginVeterinario(String usuario, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = 
                   
                new MySqlCommand("SELECT * FROM trabajador where usuario = @usuario AND contraseña = @contraseña", conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);


                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    return resultado.GetString(1);
                }
                conexion.Close();
                return "error de usuario/contraseña";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }
    }
}
