using CapaDeAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Operaciones
{
    public class Operaciones
    {
        private DB_Operaciones op = new DB_Operaciones();

        public DataTable obtenerOperacion()
        {
            return op.getOperaciones();
        }
    }
}
