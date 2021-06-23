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
    public partial class AcercaDe : Form
    {
        private string nn;
        public AcercaDe(string info)
        {
            InitializeComponent();
            nn = info;
        }

        private void AcercaDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal princ = new Principal(nn);
            princ.Show();
            this.Dispose();
        }
    }
}
