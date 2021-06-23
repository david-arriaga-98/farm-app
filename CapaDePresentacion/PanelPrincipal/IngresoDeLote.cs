using CapaDeDominio.Excepciones;
using CapaDeDominio.Hectareas;
using CapaDeDominio.Lotes;
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
    public partial class IngresoDeLote : Form
    {
        private CD_Hectareas cd_hect = new CD_Hectareas();
        private DataTable tabla = new DataTable();
        private DataRow row;

        private CN_Lotes cn_lotes = new CN_Lotes();

        public IngresoDeLote()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void IngresoDeLote_Load(object sender, EventArgs e)
        {
            hectareas.DropDownStyle = ComboBoxStyle.DropDownList;

            tabla = cd_hect.obtenerHectarea();


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                row = tabla.Rows[i];
                hectareas.Items.Add(row["Nombre"].ToString());
            }

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int hectareaID = hectareas.SelectedIndex;
            string nombre = txtNombre.Text;

            if (hectareaID == -1 || nombre == "")
            {
                MessageBox.Show("Todos los campos deben ser completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                row = tabla.Rows[hectareaID];

                if(cn_lotes.agregarLote(nombre, row["ID"].ToString()))
                {
                    MessageBox.Show("Este lote, fuè registrado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hectareas.SelectedIndex = -1;
                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la informaciòn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
