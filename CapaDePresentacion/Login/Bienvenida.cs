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

namespace CapaDePresentacion.Login
{
    public partial class Bienvenida : Form
    {
        private string nn;
        public Bienvenida(string bienvenida)
        {
            InitializeComponent();
            label2.Text = bienvenida;
            nn = bienvenida;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login ll = new Login();
            this.Dispose();
            ll.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal(nn);
            this.Dispose();
            principal.Show();
        }

        private void Bienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
