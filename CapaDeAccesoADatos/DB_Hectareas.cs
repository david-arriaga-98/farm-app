using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoADatos
{
    public class DB_Hectareas
    {
        private DB_Conexion conexion = new DB_Conexion();
        private SqlCommand command = new SqlCommand();
        private DataTable tabla = new DataTable();
        SqlDataReader leer;
        public bool agregarHectarea(int lotes, string nombre, double hectarea)
        {
            
            try
            {
                string hectare = hectarea.ToString();
                hectare = hectare.Replace(",", ".");

                command.Connection = conexion.abrirConexion();
                command.CommandText = "insert into hectareas(Lotes, Nombre, Tamanio) values (" + lotes + ", '" + nombre + "', " + hectare + ")";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public DataTable obtenerHectareas() 
        {
            command.Connection = conexion.abrirConexion();
            command.CommandText = "SELECT * FROM hectareas";
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;

        }

    }
}
