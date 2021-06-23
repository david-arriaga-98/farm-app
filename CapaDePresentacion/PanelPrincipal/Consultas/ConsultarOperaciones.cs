using CapaDeDominio.Operaciones;
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
    public partial class ConsultarOperaciones : Form
    {

        public ConsultarOperaciones()
        {
            InitializeComponent();
        }

        private void ConsultarOperaciones_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            DataTable table = new DataTable();
            table = op.obtenerOperacion();

            for(int i = 0; i < table.Rows.Count; i++)
            {
                int literal = i + 1;
                lista.Items.Add(literal + ".- " +table.Rows[i][1]);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
