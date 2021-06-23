using CapaDeDominio.Excepciones;
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

namespace CapaDePresentacion.PanelPrincipal
{
    public partial class IngresoDeHectareas : Form
    {
        private CD_Hectareas hectare = new CD_Hectareas();

        private string lotes;
        private string hectarea;
        private string nombre;

        public IngresoDeHectareas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLotes.Text = "";
            txtHectarea.Text = "";
            txtNombre.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           this.lotes = txtLotes.Text;
           this.hectarea = txtHectarea.Text;
           this.nombre = txtNombre.Text;

            try
            {
                if (hectare.agregarHectarea(this.lotes, this.nombre, this.hectarea))
                {
                    MessageBox.Show("Hectarea guardada correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLotes.Text = "";
                    txtHectarea.Text = "";
                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar tu informaciòn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArduinoExcepcion ex)
            {
                MessageBox.Show(ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
