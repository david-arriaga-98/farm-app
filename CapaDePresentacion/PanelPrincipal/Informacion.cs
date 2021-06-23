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
    public partial class Informacion : Form
    {
        private string nn;
        public Informacion(string info)
        {
            InitializeComponent();
            this.nn = info;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal princ = new Principal(nn);
            princ.Show();
            this.Dispose();
        }

        private void Informacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
