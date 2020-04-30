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
    //WRITTEN AND DIRECTED BY ALVARO GARCIA HERRERO
    
    class Conexion
    {
        public string clienteActual;
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");
        }

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
                    //EL CODIGO ESTA CORRECTO PALABRA DE FRAXITO SI FALLA ES POR EL XAMPP
                    string passwordConHash = resultado.GetString("contraseña");
                    if(BCrypt.Net.BCrypt.Verify(contraseña, passwordConHash))
                    {
                        return true;
                    }
                    return false;
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
        public Boolean loginTrabajador(String usuario, String contraseña)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                new MySqlCommand("SELECT * FROM trabajador where usuario = @usuario", conexion);
                consulta.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader resultado = consulta.ExecuteReader();

                if (resultado.Read())
                {
                    //AQUI SE CHEQUEA LA CONTRASEÑA DE HASH
                    //EL CODIGO ESTA CORRECTO PALABRA DE FRAXITO SI FALLA ES POR EL XAMPP
                    string passwordConHash = resultado.GetString("contraseña");
                    if (BCrypt.Net.BCrypt.Verify(contraseña, passwordConHash))
                    {
                        return true;
                    }
                    return false;
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
        public String insertaMascota(String nombre_mascota, String chip_mascota, String nombre_trabajador, String raza_mascota, String fecha_na_mascota, String dni_cliente)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO mascota (nombre_mascota, chip_mascota, nombre_trabajador, raza_mascota, fecha_na_mascota, dni_cliente) VALUES (@nombre_mascota, @chip_mascota, @nombre_trabajador, @raza_mascota, @fecha_na_mascota, @dni_cliente)", conexion);
                consulta.Parameters.AddWithValue("@nombre_mascota", nombre_mascota);
                consulta.Parameters.AddWithValue("@chip_mascota", chip_mascota);
                consulta.Parameters.AddWithValue("@nombre_trabajador", nombre_trabajador);
                consulta.Parameters.AddWithValue("@raza_mascota", raza_mascota);
                consulta.Parameters.AddWithValue("@fecha_na_mascota", fecha_na_mascota);
                consulta.Parameters.AddWithValue("@dni_cliente", dni_cliente);

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
        public String insertaVacuna(String chip_mascota, DateTime dia_emision, DateTime dia_caducidad, String nombre_vacuna)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO vacunas (chip_mascota, dia_emision, dia_caducidad, nombre_vacuna) VALUES (@chip_mascota, @dia_emision, @dia_caducidad, @nombre_vacuna)", conexion);
                consulta.Parameters.AddWithValue("@chip_mascota", chip_mascota);
                consulta.Parameters.AddWithValue("@dia_emision", dia_emision);
                consulta.Parameters.AddWithValue("@dia_caducidad", dia_caducidad);
                consulta.Parameters.AddWithValue("@nombre_vacuna", nombre_vacuna);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Vacuna Registrada con EXITO, reinicia la App para ver la cita nueva.";
            }
            catch (MySqlException e)
            {
                return "error fatal";
            }
        }
        public String insertaPeluqueria(String chip_mascota, DateTime dia_peluqueria, String tratamiento)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO peluqueria (chip_mascota, dia_peluqueria, tratamiento) VALUES (@chip_mascota, @dia_peluqueria, @tratamiento)", conexion);
                consulta.Parameters.AddWithValue("@chip_mascota", chip_mascota);
                consulta.Parameters.AddWithValue("@dia_peluqueria", dia_peluqueria);
                consulta.Parameters.AddWithValue("@tratamiento", tratamiento);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Cita Registrada con EXITO, reinicia la App para ver la cita nueva.";
            }
            catch (MySqlException e)
            {
                return "error fatal";
            }
        }
        public String insertaRevision(String chip_mascota, DateTime dia_revision, String motivo_revision)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("INSERT INTO revisiones (chip_mascota, dia_revision, motivo_revision) VALUES (@chip_mascota, @dia_revision, @motivo_revision)", conexion);
                consulta.Parameters.AddWithValue("@chip_mascota", chip_mascota);
                consulta.Parameters.AddWithValue("@dia_revision", dia_revision);
                consulta.Parameters.AddWithValue("@motivo_revision", motivo_revision);

                consulta.ExecuteNonQuery();

                conexion.Close();
                return "Revisión Registrada con EXITO, reinicia la App para ver la revisión nueva.";
            }
            catch (MySqlException e)
            {
                return "error fatal";
            }
        }
        public DataTable getMascotas()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascota", conexion);
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
        //public DataTable getAllMascotas(string nombre)
        //{
        //    try
        //    {
        //        conexion.Open();
        //        MySqlCommand consulta =
        //            new MySqlCommand("SELECT * FROM mascota", conexion);
        //        MySqlDataReader resultado = consulta.ExecuteReader();
        //        DataTable mascotas = new DataTable();
        //        mascotas.Load(resultado);
        //        conexion.Close();
        //        return mascotas;
        //    }
        //    catch (MySqlException e)
        //    {
        //        throw e;
        //    }
        //}
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
        public DataTable getAllClientes(string nombre)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM cliente WHERE dni_cliente like '" + nombre + "'", conexion);
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
        public DataTable getAllMascotas(string nombre)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM mascota WHERE chip_mascota like '" + nombre + "'", conexion);
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
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM mascota where chip_mascota = '" + chip + "'", conexion);
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
        public DataTable getTienda()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM tienda ", conexion);
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
        public DataTable getVacunas()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM vacunas ", conexion);
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
        public DataTable getPeluqueria()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM peluqueria ", conexion);
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
        public DataTable getRevision()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT * FROM revisiones ", conexion);
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
    }
}
