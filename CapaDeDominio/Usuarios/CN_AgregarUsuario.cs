using CapaDeAccesoADatos;
using CapaDeDominio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDominio.Usuarios
{
    public class CN_AgregarUsuario
    {
        private DB_Usuario user = new DB_Usuario();

        private string nombre;
        private string apellido;
        private string cedula;
        private string contra;

        public CN_AgregarUsuario(string nombre, string apellido, string cedula, string contra)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.contra = contra;
        }

        public bool agregar()
        {
            //Validamos los datos
            if (this.nombre == "" || this.apellido == "" || this.cedula == "" || this.contra == "")
            {
                throw new ArduinoExcepcion("Todos los campos deben ser completados");
            }
            else
            {
                if(nombre.Length < 3 || nombre.Length > 99)
                {
                    throw new ArduinoExcepcion("El nombre tiene una longitud invàlida");
                }
                else
                {
                    if (apellido.Length < 3 || apellido.Length > 99)
                    {
                        throw new ArduinoExcepcion("El apellido tiene una longitud invàlida");
                    }
                    else
                    {
                        if (validateSchedule(this.cedula))
                        {

                            if (cedula.Length < 8 || apellido.Length > 99)
                            {
                                throw new ArduinoExcepcion("La contraseña tiene una longitud invàlida");
                            }
                            else
                            {
                                int respuesta = user.guardarUsuario(this.nombre, this.apellido, this.cedula, this.contra);

                                if (respuesta == 1)
                                {
                                    return true;
                                }
                                else if (respuesta == 2627) {
                                    throw new ArduinoExcepcion("La cèdula ya està registrada");
                                }
                                else
                                {
                                    throw new ArduinoExcepcion("Ha ocurrido un error");
                                }

                            }

                        }
                        return false;
                    }
                }
            }
        }

        public bool validateSchedule(string cedula)
        {
            try
            {
                Convert.ToInt64(cedula);

                //Validamos la longitud
                if (cedula.Length == 10)
                {
                    //Validamos que los dos primeros digitos no sean mayor a 24
                    string dosNumeros = cedula[0] + "" + cedula[1];

                    if (Convert.ToInt16(dosNumeros) > 0 && Convert.ToInt16(dosNumeros) < 25)
                    {
                        int[] numbers = new int[10];

                        for (int i = 0; i < numbers.Length; i ++) {
                            numbers[i] = Convert.ToInt16(Convert.ToString(cedula[i]));
                        }

                        if (numbers[2] > -1 && numbers[2] < 6)
                        {

                            int[] pares = new int[4];
                            int[] impares = new int[5];
                            int paresCount = 0;
                            int imparesCount = 0;

                            //Para impares
                            for (int i = 0; i < 9; i += 2)
                            {
                                impares[imparesCount] = numbers[i];
                                int numeroMult = impares[imparesCount] * 2;
                                if (numeroMult > 9)
                                {
                                    numeroMult = numeroMult - 9;
                                }
                                impares[imparesCount] = numeroMult;
                                imparesCount++;
                            }
                            //Para pares
                            for (int i = 1; i < 8; i += 2)
                            {
                                pares[paresCount] = numbers[i];
                                paresCount++;
                            }
                            //Sumamos los valores
                            int sumaPares = 0;
                            int sumaImpares = 0;

                            for (int i = 0; i < pares.Length; i++)
                            {
                                sumaPares = pares[i] + sumaPares;
                            }

                            for (int i = 0; i < impares.Length; i++)
                            {
                                sumaImpares = impares[i] + sumaImpares;
                            }

                            int sumaTotal = sumaPares + sumaImpares;

                            int modulo = sumaTotal % 10;
                            int numeroValidador;

                            if (modulo == 0)
                            {
                                numeroValidador = 0;
                            }
                            else
                            {
                                numeroValidador = 10 - modulo;
                            }
                            if (numeroValidador == numbers[9])
                            {
                                return true;
                            }
                        }

                    }
                    throw new ArduinoExcepcion("Nùmero de cèdula no vàlido");
                }
                else
                {
                    throw new ArduinoExcepcion("La cèdula debe tener 10 dìgitos");
                }
            }
            catch (FormatException)
            {
                throw new ArduinoExcepcion("La cèdula es invàlida");
            }
        }


    }
}
