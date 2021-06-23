using CapaDeDominio.Hectareas;
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
    public partial class ConsultarHectarea : Form
    {
        private CD_Hectareas hectareas = new CD_Hectareas();
        public ConsultarHectarea()
        {
            InitializeComponent();
        }

        private void ConsultarHectarea_Load(object sender, EventArgs e)
        {
            
            lista.DataSource = hectareas.obtenerHectarea();
            lista.Columns[0].Width = 50;
            lista.Columns[1].Width = 75;
            lista.Columns[2].Width = 150;
            lista.Columns[2].Width = 100;
            lista.Columns[2].HeaderText = "Nombre";
            lista.Columns[3].HeaderText = "Tamaño (metros)";

            total.Text = "Total de Hectareas: " + lista.Rows.Count;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
