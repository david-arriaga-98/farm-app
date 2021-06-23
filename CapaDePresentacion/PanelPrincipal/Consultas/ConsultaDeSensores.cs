using CapaDeDominio.Sensores;
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
    public partial class ConsultaDeSensores : Form
    {
        private CN_Sensores sensor = new CN_Sensores();
        private DataTable tabla1 = new DataTable();
        public ConsultaDeSensores()
        {
            InitializeComponent();
        }

        private void ConsultaDeSensores_Load(object sender, EventArgs e)
        {
            tabla1 = sensor.obtenerSensores();

            tabla.DataSource = tabla1;
            tabla.Columns[0].Width = 50;
            tabla.Columns[1].Width = 150;
            tabla.Columns[2].Width = 150;
            total.Text = "" + tabla1.Rows.Count;
            
        }
    }
}
