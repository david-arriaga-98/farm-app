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

namespace CapaDePresentacion.PanelPrincipal
{
    public partial class IngresoDeSensores : Form
    {
        private CN_Sensores sensor = new CN_Sensores();

        public IngresoDeSensores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo = txtCode.Text;
            int tipo = epoca.SelectedIndex;
            if (tipo == -1)
            {
                MessageBox.Show("Debe escoger una opciòn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(sensor.guardarSensores(codigo, (string)epoca.SelectedItem))
                {
                    MessageBox.Show("Has guardado tu registro correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    generarCodigo();
                    epoca.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar tu infomaciòn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IngresoDeSensores_Load(object sender, EventArgs e)
        {
            generarCodigo();
            epoca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void generarCodigo()
        {
            CN_Sensores sensor2 = new CN_Sensores();
            int valor = sensor2.obtenerSensores().Rows.Count;
            txtCode.Text = "SENSOR-00-" + valor;
        }
    }
}
