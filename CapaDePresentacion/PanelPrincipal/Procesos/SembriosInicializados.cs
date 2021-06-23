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

namespace CapaDePresentacion.PanelPrincipal.Procesos
{
    public partial class SembriosInicializados : Form
    {
        public SembriosInicializados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SembriosInicializados_Load(object sender, EventArgs e)
        {
            agregarSembrios();
            lista.Columns[0].Width = 50;
            lista.Columns[1].Width = 150;

            lista.Columns[4].Width = 70;
            lista.Columns[5].Width = 70;
            lista.Columns[6].Width = 70;
            lista.Columns[7].Width = 70;
        }

        private void agregarSembrios()
        {
            CN_Sembrios sembrios3 = new CN_Sembrios();
            DataTable table = new DataTable();
            table = sembrios3.obtenerSembriosInicializados();
            lista.DataSource = table;
        }

        private void lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                try
                {
                    CN_Sembrios sembrios2 = new CN_Sembrios();
                    try
                    {
                        string idSembrio = lista.Rows[e.RowIndex].Cells[0].Value.ToString();

                        if (sembrios2.terminarSembrio(idSembrio))
                        {
                            MessageBox.Show("Sembrìo terminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lista.RefreshEdit();
                            agregarSembrios();
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        //No hara nada
                    }

                }
                catch (ArduinoExcepcion ex)
                {
                    MessageBox.Show(ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }
    }
}
