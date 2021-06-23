using CapaDeAccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Sensores
{
    public class CN_Sensores
    {
        private DB_Sensores sensores = new DB_Sensores();
        public DataTable obtenerSensores()
        {
            return sensores.obtenerSensores();
        }

        public bool guardarSensores(string codigo, string tipo)
        {
            return sensores.guardarSensor(codigo, tipo);
        }

    }
}
