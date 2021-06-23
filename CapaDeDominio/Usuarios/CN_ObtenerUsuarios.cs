using CapaDeAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Usuarios
{
    public class CN_ObtenerUsuarios
    {
        private DB_Usuario usuario = new DB_Usuario();

        public DataTable obtenerUser()
        {
            return usuario.obtenerUsers();
        }
    }
}
