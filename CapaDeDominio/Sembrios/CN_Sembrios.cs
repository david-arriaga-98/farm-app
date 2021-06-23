using CapaDeAccesoADatos;
using CapaDeDominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Sembrios
{
    public class CN_Sembrios
    {
        private DB_Sembrios db_sembrios = new DB_Sembrios();
        public DataTable obtenerSembrios()
        {
            return db_sembrios.obtenerSembrios();
        }

        public bool guardarSembrio(string codigo, string nombre, string epoc, string duracion)
        {
            //Validamos
            if (nombre == "" || duracion == "")
            {
                throw new ArduinoExcepcion("Todos los campos deben ser completados");
            }
            else
            {

                //Validamos la duraciòn
                try
                {
                    duracion = duracion.Replace(",", ".");
                    Convert.ToDouble(duracion);
                    return db_sembrios.guardarSembrios(codigo, nombre, epoc, duracion);
                }
                catch (FormatException)
                {
                    throw new ArduinoExcepcion("La duraciòn del sembrìo solo podrà ser nùmeros");
                }
            }
        }


        public bool iniciarSembrio(string id)
        {
            DataTable verificar = new DataTable();
            verificar =  db_sembrios.verificarSembrios("select * from sembrios where ID="+ id +" AND Iniciado='NO'");
            if (verificar.Rows.Count == 0)
            {
                throw new ArduinoExcepcion("El sembrìo ya està iniciado");
            }
            else
            {
                if (db_sembrios.iniciarSembrio(id))
                {
                    DataRow row = verificar.Rows[0];
                    string mensaje = "Se iniciò el sembrìo " + row[1].ToString() + " el " + DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                    DB_Operaciones op = new DB_Operaciones();
                    op.agregarMensaje(mensaje);
                    return true;
                }
                else
                {
                    throw new ArduinoExcepcion("Ha ocurrido un error al intentar actualizar la informaciòn");
                }
            }
            
        }

        public bool terminarSembrio(string id)
        {
            DataTable verificar = new DataTable();
            verificar = db_sembrios.verificarSembrios("select * from sembrios where ID=" + id + " AND Iniciado='SI'");
            if (verificar.Rows.Count == 0)
            {
                throw new ArduinoExcepcion("El sembrìo no ha sido inicializado");
            }
            else
            {
                if (db_sembrios.finalizarSembrio(id))
                {
                    DataRow row = verificar.Rows[0];
                    string mensaje = "Se terminò el sembrìo " + row[1].ToString() + " el " + DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                    DB_Operaciones op = new DB_Operaciones();
                    op.agregarMensaje(mensaje);
                    return true;
                }
                else
                {
                    throw new ArduinoExcepcion("Ha ocurrido un error al intentar actualizar la informaciòn");
                }
            }

        }

        public DataTable obtenerSembriosInicializados()
        {
            return db_sembrios.verificarSembrios("select * from sembrios where Iniciado='SI'");
        }

        public bool actInaSembrio(string id, bool accion)
        {
            return db_sembrios.activarDesactivarSembrio(id, accion);
        }

        public bool actInaRiego(string id, bool accion)
        {
            return db_sembrios.activarDesactivarRiego(id, accion);
        }


    }
}
