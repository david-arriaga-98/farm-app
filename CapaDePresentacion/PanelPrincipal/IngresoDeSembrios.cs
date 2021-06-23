using CapaDeDominio.Excepciones;
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

namespace CapaDePresentacion.PanelPrincipal
{
    public partial class IngresoDeSembrios : Form
    {
        private CN_Sembrios sembrios = new CN_Sembrios();

        public IngresoDeSembrios()
        {
            InitializeComponent();
        }

        private void IngresoDeSembrios_Load(object sender, EventArgs e)
        {
            epoca.DropDownStyle = ComboBoxStyle.DropDownList;

            ejecutarCodigo();
        }

        private void ejecutarCodigo()
        {
            CN_Sembrios sembrio = new CN_Sembrios();
            DataTable table = new DataTable();
            table = sembrio.obtenerSembrios();
            int num = table.Rows.Count + 1;
            txtCode.Text = "Sembrio-00-" + num;
            
        }

        private void guardarSembrio()
        {
            string codigo = txtCode.Text;
            string nombre = txtNombre.Text;
            string epoc = (string) epoca.SelectedItem;
            string duracion = txtDuration.Text;

            try
            {
                if(epoca.SelectedIndex == -1)
                {
                    MessageBox.Show("Todos los campos deben ser completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (sembrios.guardarSembrio(codigo, nombre, epoc, duracion))
                    {
                        MessageBox.Show("El sembrìo se registrò correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ejecutarCodigo();
                        txtNombre.Text = "";
                        txtDuration.Text = "";
                        epoca.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (ArduinoExcepcion ex)
            {
                MessageBox.Show(ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarSembrio();
        }
    }
}
