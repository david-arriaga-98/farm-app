using CapaDeAccesoADatos;
using CapaDeDominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Hectareas
{
    public class CD_Hectareas
    {
        private DB_Hectareas db_hectarea = new DB_Hectareas();

        public bool agregarHectarea(string lotes, string nombre, string hectarea)
        {
            //Validamos que n hay campos vacios
            if (lotes == "" || nombre == "" || hectarea == "")
            {
                throw new ArduinoExcepcion("No puede haber campos vacìos");
            }
            else
            {
                try
                {
                    //Parseamos los datos de los lotes
                    int lote = Convert.ToInt32(lotes);
                    try
                    {
                        hectarea = hectarea.Replace(".", ",");
                        double hectare = Convert.ToDouble(hectarea);
                        return db_hectarea.agregarHectarea(lote, nombre, hectare);
                    }
                    catch (FormatException)
                    {
                        throw new ArduinoExcepcion("Hectarea invàlido, solo pueden haber nùmeros");
                    }
                }
                catch (FormatException)
                {
                    throw new ArduinoExcepcion("Lote invàlido, solo pueden haber nùmeros");
                }
            }
        }

        public DataTable obtenerHectarea()
        {
            return db_hectarea.obtenerHectareas();
        }

    }
}
