using CapaDeDominio.Sembrios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PanelPrincipal.Consultas
{
    public partial class ConsultarSembrio : Form
    {
        private CN_Sembrios sembrios = new CN_Sembrios();
        public ConsultarSembrio()
        {
            InitializeComponent();
        }

        private void ConsultarSembrio_Load(object sender, EventArgs e)
        {
           
            agregarSembrios();
            lista.Columns[0].Width = 50;
            lista.Columns[1].Width = 150;
            total.Text = "" + lista.Rows.Count;
            lista.Columns[5].Visible = false;
            lista.Columns[6].Visible = false;
            lista.Columns[7].Visible = false;
        }

        private void agregarSembrios()
        {
            
            lista.DataSource = sembrios.obtenerSembrios();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
