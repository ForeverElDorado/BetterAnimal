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

        // public String loginVeterinario(String usuario, String contraseña)
        public Boolean loginVeterinario(String usuario, String contraseña)
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
                    // return resultado.GetString(1);
                    return true;
                }
                conexion.Close();
                //return "error de usuario/contraseña";
                return false;
            }
            catch (MySqlException e)
            {
                // return "error";
                return false;
            }
        }
        /*CODIGO PARA INSERTAR USUARIOS EN LA BASE DE DATOS, HAY QUE AÑADIR STRING POR CAMPO (NOMBRE APELLIDOS TELEFONO EMAIL...)
         * 
         */
        public String insertaUsuario(String DNI, String Nombre, String pass)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO usuario (id, DNI, Nombre, pass) VALUES (NULL, @DNI, @Nombre, @pass)", conexion);
                    consulta.Parameters.AddWithValue("@DNI", DNI);
                    consulta.Parameters.AddWithValue("@Nombre", Nombre);
                    consulta.Parameters.AddWithValue("@pass", pass);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }
    }
}
