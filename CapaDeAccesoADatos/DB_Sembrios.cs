using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeAccesoADatos
{
    public class DB_Sembrios
    {

        private DB_Conexion conexion = new DB_Conexion();
        private SqlCommand command = new SqlCommand();
        private DataTable tabla = new DataTable();
        SqlDataReader leer;

        public DataTable obtenerSembrios()
        {
            command.Connection = conexion.abrirConexion();
            command.CommandText = "SELECT * FROM sembrios";
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;

        }

        public bool guardarSembrios(string codigo, string nombre, string epoc, string duracion)
        {
            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "insert into sembrios(Codigo, Nombre, Epoca, Duracion ) values ('" + codigo + "', '" + nombre + "', '" + epoc + "', " + duracion + ")";
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
                conexion.cerrarConexion();
            }
        }


        public DataTable verificarSembrios(string texto)
        {
            command.Connection = conexion.abrirConexion();
            command.CommandText = texto;
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;

        }

        public bool iniciarSembrio(string id)
        {

            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "update sembrios set Iniciado='SI' where ID=" + id;
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
                conexion.cerrarConexion();
            }
        }


        public bool finalizarSembrio(string id)
        {

            try
            {
                command.Connection = conexion.abrirConexion();
                command.CommandText = "update sembrios set Iniciado='NO' where ID=" + id;
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
                conexion.cerrarConexion();
            }
        }

        public bool activarDesactivarSembrio(string id, bool accion)
        {
            try
            {
                command.Connection = conexion.abrirConexion();
                if (accion)
                {
                    command.CommandText = "update sembrios set Activo='SI' where id=" + id;
                }
                else
                {
                    command.CommandText = "update sembrios set Activo='NO' where id=" + id;
                }
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
                conexion.cerrarConexion();
            }
            
        }

        public bool activarDesactivarRiego(string id, bool accion)
        {
            try
            {
                command.Connection = conexion.abrirConexion();
                if (accion)
                {
                    command.CommandText = "update sembrios set Riego='SI' where id=" + id;
                }
                else
                {
                    command.CommandText = "update sembrios set Riego='NO' where id=" + id;
                }
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
                conexion.cerrarConexion();
            }

        }

    }
}
