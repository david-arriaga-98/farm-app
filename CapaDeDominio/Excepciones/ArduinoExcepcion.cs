using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Excepciones
{
    public class ArduinoExcepcion : Exception
    {
        public string message { get; protected set; }

        public ArduinoExcepcion(string message, System.Exception ex = null) : 
            base("Error al validad tu información", ex)
        {
            this.message = message;
        }
    }
}
