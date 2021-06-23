using CapaDeDominio.Excepciones;
using CapaDeDominio.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PanelPrincipal
{
    public partial class IngresoDeUsuarios : Form
    {
        private string name;
        private string apellido;
        private string password;
        private string cedula;

        private CN_AgregarUsuario agregar;

        public IngresoDeUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.Show();
            this.Dispose();
        }

        private void guardarUsuario()
        {
            //Recogemos los datos
            this.name = btnNombre.Text;
            this.apellido = btnApellido.Text;
            this.cedula = btnCedula.Text;
            this.password = btnPass.Text;

            try
            {
                this.agregar = new CN_AgregarUsuario(this.name, this.apellido, this.cedula, this.password);

                if (this.agregar.agregar())
                {
                    MessageBox.Show("Usuario registrado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login.Login login = new Login.Login();
                    login.Show();
                    this.Dispose();
                }

            }
            catch(ArduinoExcepcion ex)
            {
                MessageBox.Show(ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarUsuario();
        }

        private void IngresoDeUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
