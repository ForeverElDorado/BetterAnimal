using System;
using System.Collections.Generic;
using System.Data;
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
                new MySqlCommand("SELECT * FROM cliente where usuario = @usuario",conexion);
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
        public String insertaCliente(String dni_cliente, String nombre_cliente, String apellido_cliente, String telefono, String chip_mascota, String email, String usuario, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO cliente (dni_cliente, nombre_cliente, apellido_cliente, telefono, chip_mascota, email, usuario, contraseña ) VALUES (@dni_cliente, @nombre_cliente, @apellido_cliente, @telefono, @chip_mascota, @email, @usuario, @contraseña )", conexion);
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
        public String insertaMascota(String nombre_mascota, String chip_mascota, String nombre_trabajador, String raza_mascota, String fecha_na_mascota)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO mascotas (nombre_mascota, chip_mascota, nombre_trabajador, raza_mascota, fecha_na_mascota) VALUES (@nombre_mascota, @chip_mascota, @nombre_trabajador, @raza_mascota, @fecha_na_mascota)", conexion);
                consulta.Parameters.AddWithValue("@nombre_mascota", nombre_mascota);
                consulta.Parameters.AddWithValue("@chip_mascota", chip_mascota);
                consulta.Parameters.AddWithValue("@nombre_trabajador", nombre_trabajador);
                consulta.Parameters.AddWithValue("@raza_mascota", raza_mascota);
                consulta.Parameters.AddWithValue("@fecha_na_mascota", fecha_na_mascota);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "ok";
            }
            catch (MySqlException e)
            {
                return "error";
            }
        }
        public String insertaTrabajador(String dni_trabajador, String nombre_trabajador, String apellido_trabajador, String telefono, String email, String usuario, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO trabajador (dni_trabajador, nombre_trabajador, apellido_trabajador, telefono, email, usuario, contraseña ) VALUES (@dni_trabajador, @nombre_trabajador, @apellido_trabajador, @telefono, @email, @usuario, @contraseña)", conexion);
                consulta.Parameters.AddWithValue("@dni_trabajador", dni_trabajador);
                consulta.Parameters.AddWithValue("@nombre_trabajador", nombre_trabajador);
                consulta.Parameters.AddWithValue("@apellido_trabajador", apellido_trabajador);
                consulta.Parameters.AddWithValue("@telefono", telefono);
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
        public DataTable getMascotas()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascotas ", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();
                return mascotas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getClientes()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM cliente ", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getClientePorDNI(String dni)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM cliente where dni_cliente = '" + dni + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable clientes = new DataTable();
                clientes.Load(resultado);
                conexion.Close();
                return clientes;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getAnimalPorChip(String chip)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascotas where chip_mascota = '" + chip + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable mascotas = new DataTable();
                mascotas.Load(resultado);
                conexion.Close();
                return mascotas;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
