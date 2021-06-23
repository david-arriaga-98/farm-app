using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoADatos
{
    public class DB_Lotes
    {
        DB_Conexion conexion = new DB_Conexion();
        SqlCommand command = new SqlCommand();

        public bool agregarLote(string nombre, string hectareaID)
        {
            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "insert into lotes(ID_Hectareas, Nombre) values (" + hectareaID + ", '" + nombre + "')";
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
