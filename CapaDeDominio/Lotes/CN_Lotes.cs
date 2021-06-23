using CapaDeAccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Lotes
{
    public class CN_Lotes
    {
        private DB_Lotes lotes = new DB_Lotes();
        public bool agregarLote(string nombre, string hectareaID)
        {
            return lotes.agregarLote(nombre, hectareaID);
        }

    }
}
