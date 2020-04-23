using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;

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
                new MySqlCommand("SELECT * FROM prueba where usuario = @usuario",conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    //AQUI SE CHEQUEA LA CONTRASEÑA DE HASH
                    //nombre de la columna ¿1?
                    string passwordConHash = resultado.GetString("contraseña");
                    if(BCrypt.Net.BCrypt.Verify(contraseña, passwordConHash))
                    {
                        return true;
                    }
                    return false;
                    // return resultado.GetString(1);
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
        //public String insertaUsuario(String DNI, String usuario, String contraseña)
        //{
        //    try
        //    {
        //        conexion.Open();
        //        MySqlCommand consulta =
        //            new MySqlCommand("INSERT INTO prueba (usuario, contraseña) VALUES (@Usuario, @contraseña)", conexion);
        //            consulta.Parameters.AddWithValue("@usuario", usuario);
        //            consulta.Parameters.AddWithValue("@contraseña", contraseña);

        //        consulta.ExecuteNonQuery();

        //        conexion.Close();
        //        return "ok";
        //    }
        //    catch (MySqlException e)
        //    {
        //        return "error";
        //    }
        //}
        public String insertaUsuario(String dni_cliente, String nombre_cliente, String apellido_cliente, String telefono, String chip_mascota, String email, String usuario, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO cliente (dni_cliente, nombre_cliente, apellido_cliente, telefono, chip_mascota, email, usuario, contraseña ) VALUES (@dni_cliente, @nombre_cliente, @apellido_cliente, @direccion, @chip_mascota, @id, @usuario, @contraseña )", conexion);
                consulta.Parameters.AddWithValue("@dni_cliente", dni_cliente);
                consulta.Parameters.AddWithValue("@nombre_cliente", nombre_cliente);
                consulta.Parameters.AddWithValue("@apellido_cliente", apellido_cliente);
                consulta.Parameters.AddWithValue("@telefono", telefono);
                consulta.Parameters.AddWithValue("@chip_mascota", chip_mascota);
                consulta.Parameters.AddWithValue("@email", email);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                consulta.Parameters.AddWithValue("@contraseña", contraseña);

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
