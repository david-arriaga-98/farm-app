using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeAccesoADatos
{
    public class DB_Conexion
    {
        private SqlConnection connection = new SqlConnection("Server=(local); DataBase=ARDURIEGO_DATABASE; Integrated Security=true");
       

        public SqlConnection abrirConexion()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }

        public SqlConnection cerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }
    }
}
