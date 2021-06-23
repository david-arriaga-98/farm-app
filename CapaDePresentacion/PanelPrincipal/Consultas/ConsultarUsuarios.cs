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

namespace CapaDePresentacion.PanelPrincipal.Consultas
{
    public partial class ConsultarUsuarios : Form
    {
        public ConsultarUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarUsuarios_Load(object sender, EventArgs e)
        {
            actualizarUsuarios();
        }

        private void actualizarUsuarios()
        {
            CN_ObtenerUsuarios usuario = new CN_ObtenerUsuarios();
            lista.DataSource = usuario.obtenerUser();

            lista.Columns[4].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string opcion = Convert.ToString(MessageBox.Show("Seguro deseas eliminar este usuario", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if(opcion == "Yes")
            {
                string id = lista.Rows[e.RowIndex].Cells[0].Value.ToString();
                CN_EliminarUsuario eliminar = new CN_EliminarUsuario(id);
                if (eliminar.eliminar())
                {
                    MessageBox.Show("Usuario eliminado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lista.RefreshEdit();
                    actualizarUsuarios();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
