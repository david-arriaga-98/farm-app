using CapaDePresentacion.PanelPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDominio.Login;
using CapaDeDominio.Excepciones;

namespace CapaDePresentacion.Login
{
    public partial class Login : Form
    {
        private string usuario;
        private string clave;
        private CN_Login login;

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.iniciarSesion();
        }

        private void iniciarSesion()
        {
            //Recogemos los valores
            this.usuario = txtUser.Text;
            this.clave = txtPass.Text;

            try
            {
                this.login = new CN_Login(this.usuario, this.clave);
                
                Bienvenida principal = new Bienvenida(this.login.ejecutarLogin());
                principal.Show();
                this.Dispose();

            }
            catch (ArduinoExcepcion ex)
            {
                MessageBox.Show(ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                iniciarSesion();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                iniciarSesion();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            IngresoDeUsuarios ingreso = new IngresoDeUsuarios();
            ingreso.Show();
            this.Dispose();
        }
    }
}
