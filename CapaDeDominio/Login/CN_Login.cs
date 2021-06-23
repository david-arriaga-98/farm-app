using CapaDeAccesoADatos;
using CapaDeDominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Login
{
    public class CN_Login
    {

        private string usuario;
        private string password;

        private DB_Usuario db_user = new DB_Usuario();

        public CN_Login(string usuario, string password)
        {

            this.usuario = usuario;
            this.password = password;

        }

        public string ejecutarLogin()
        {
            //Validamos los datos
            if (this.usuario == "" || this.password == "") 
            {
                throw new ArduinoExcepcion("Debes completar todos los campos");
            }
            else
            {
                try
                {
                    
                    DataTable table = db_user.login(this.usuario, this.password);
                    return "Bienvenido/a " + table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();
                }
                catch(IndexOutOfRangeException)
                {
                    throw new ArduinoExcepcion("Usuario y/o Contraseña incorrectos");
                }

            }
        }

    }
}
