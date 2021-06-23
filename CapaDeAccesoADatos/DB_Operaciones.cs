using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoADatos
{
    public class DB_Operaciones
    {

        private DB_Conexion conexion = new DB_Conexion();
        private SqlCommand command = new SqlCommand();
        private DataTable tabla = new DataTable();
        


        public DataTable getOperaciones()
        {
            SqlDataReader leer;
            command.Connection = conexion.abrirConexion();
            command.CommandText = "SELECT * FROM operaciones";
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;

        }

        public bool agregarMensaje(string mensaje)
        {

            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "insert into operaciones(Mensaje) values ('"+mensaje+"')";
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

    }
}
