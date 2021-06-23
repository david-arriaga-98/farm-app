using CapaDePresentacion.PanelPrincipal.Consultas;
using CapaDePresentacion.PanelPrincipal.Procesos;
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
    public partial class Principal : Form
    {
        private string nn;
        public Principal(string bienvenida)
        {
            InitializeComponent();
            barraBaja.Text = bienvenida;
            this.nn = bienvenida;
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ingresoHectareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoDeHectareas ingreso = new IngresoDeHectareas();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void consultarHectariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarHectarea consultar = new ConsultarHectarea();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void ingresoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoDeUsuarios ingreso = new IngresoDeUsuarios();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void ingresoLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoDeLote ingreso = new IngresoDeLote();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void ingresoDeSembrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoDeSembrios ingreso = new IngresoDeSembrios();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void ingresoDeSensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoDeSensores ingreso = new IngresoDeSensores();
            ingreso.MdiParent = this;
            ingreso.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarSembrio consultar = new ConsultarSembrio();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void consultarSensoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDeSensores consultar = new ConsultaDeSensores();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void iniciarSembrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSembrio consultar = new IniciarSembrio();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void sembriosInicializadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SembriosInicializados consultar = new SembriosInicializados();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void consultarHistorialDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarOperaciones consultar = new ConsultarOperaciones();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void inactivarSembriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InactivarSembrio consultar = new InactivarSembrio();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void finalizarRiegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinalizarRiego consultar = new FinalizarRiego();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Informacion inf = new Informacion(nn);
            inf.Show();
            this.Dispose();
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios consultar = new ConsultarUsuarios();
            consultar.MdiParent = this;
            consultar.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acer = new AcercaDe(nn);
            acer.Show();
            this.Dispose();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda acer = new Ayuda(nn);
            acer.Show();
            this.Dispose();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte consultar = new Reporte();
            consultar.MdiParent = this;
            consultar.Show();
        }
    }
}
