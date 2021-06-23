using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoADatos
{
    public class DB_Usuario
    {

        DB_Conexion conexion = new DB_Conexion();
        SqlCommand command = new SqlCommand();
        SqlDataReader leer;
        DataTable table = new DataTable();
        

        public DataTable login(string usuario, string password)
        {
            command.Connection = conexion.abrirConexion();
            command.CommandText = "SELECT * FROM usuarios WHERE Cedula='"+usuario+"' AND Contrasena='"+password+"'";
            leer = command.ExecuteReader();
            table.Load(leer);
            conexion.cerrarConexion();
            return table;
        }

        public int guardarUsuario(string nombres, string apellidos, string cedula, string contra)
        {
            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "insert into usuarios (Nombres, Apellidos, Cedula, Contrasena) values('" + nombres + "', '" + apellidos + "', '" + cedula + "', '" + contra + "')";
                command.CommandType = CommandType.Text;

                int i = Convert.ToInt16(command.ExecuteNonQuery());

                return i;
            }
            catch (SqlException ex)
            {
                return ex.Number;
            }

            finally
            {
                conexion.cerrarConexion();
            }
        }

        public int eliminarUsuario(string id)
        {
            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "delete from usuarios where id=" + id;
                command.CommandType = CommandType.Text;

                int i = Convert.ToInt16(command.ExecuteNonQuery());

                return i;
            }
            catch (SqlException ex)
            {
                return ex.Number;
            }

            finally
            {
                conexion.cerrarConexion();
            }
        }

        public DataTable obtenerUsers()
        {
            command.Connection = conexion.abrirConexion();
            command.CommandText = "SELECT * FROM usuarios";
            leer = command.ExecuteReader();
            table.Load(leer);
            conexion.cerrarConexion();
            return table;
        }
    }
}
