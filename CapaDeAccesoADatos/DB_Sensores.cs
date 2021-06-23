using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoADatos
{
    public class DB_Sensores
    {

        private DB_Conexion conexion = new DB_Conexion();
        private SqlCommand command = new SqlCommand();
        private DataTable tabla = new DataTable();
        private SqlDataReader leer;

        public DataTable obtenerSensores()
        {
            command.Connection = conexion.abrirConexion();
            command.CommandText = "SELECT * FROM sensores";
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;

        }

        public bool guardarSensor(string  codigo, string tipo)
        {
            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "insert into sensores(Codigo, Tipo) values ('"+codigo+"', '"+tipo+"')";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexion.abrirConexion();
            }
        }


    }
}
