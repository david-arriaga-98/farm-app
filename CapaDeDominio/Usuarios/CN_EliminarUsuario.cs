using CapaDeAccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Usuarios
{
    public class CN_EliminarUsuario
    {
        private DB_Usuario user = new DB_Usuario();
        private string id;

        public CN_EliminarUsuario(string id)
        {
            this.id = id;
        }

        public bool eliminar()
        {
            if(user.eliminarUsuario(id) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
