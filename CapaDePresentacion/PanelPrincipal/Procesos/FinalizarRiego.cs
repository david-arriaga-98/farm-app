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
    public partial class FinalizarRiego : Form
    {
        public FinalizarRiego()
        {
            InitializeComponent();
        }

        private void agregarSembrios()
        {
            CN_Sembrios sembrios3 = new CN_Sembrios();
            DataTable table = new DataTable();
            table = sembrios3.obtenerSembrios();
            lista.DataSource = table;


        }

        private void FinalizarRiego_Load(object sender, EventArgs e)
        {
            agregarSembrios();
            lista.Columns[0].Width = 50;
            lista.Columns[1].Width = 150;

            lista.Columns[4].Width = 70;
            lista.Columns[5].Width = 70;
            lista.Columns[6].Width = 70;
            lista.Columns[7].Width = 70;
        }

        private void lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                try
                {
                    CN_Sembrios sembrios2 = new CN_Sembrios();
                    string idSembrio = lista.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string accion = lista.Rows[e.RowIndex].Cells[7].Value.ToString();
                    if(accion == "NO")
                    {
                        //Activamos
                        if (sembrios2.actInaRiego(idSembrio, true))
                        {
                            MessageBox.Show("El riego se ha activado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lista.RefreshEdit();
                            agregarSembrios();
                        }
                    }
                    else
                    {
                        //Desactivamos
                        if (sembrios2.actInaRiego(idSembrio, false))
                        {
                            MessageBox.Show("El riego se ha desactivado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lista.RefreshEdit();
                            agregarSembrios();
                        }
                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    //No hacemos nada
                }

            }
            catch (ArduinoExcepcion ex)
            {
                MessageBox.Show(ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
