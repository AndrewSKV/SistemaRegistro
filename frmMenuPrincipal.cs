using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaRegistro
{
    public partial class frmMenuPP : Form


    {
        private bool cerrarDesdeBotonSalir = false;
        public frmMenuPP()
        {
            InitializeComponent();
        }


        private void frmMenuPP_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuPP_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cerrarDesdeBotonSalir)
            {
                Application.Exit();
            }
            else
            {
                frmInicioSesion frmInicioSesion = new frmInicioSesion();
                frmInicioSesion.Show();
            }

        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertar frmInsertarInfo = new frmInsertar();
            frmInsertarInfo.TopLevel = false;
            frmInsertarInfo.FormBorderStyle = FormBorderStyle.None;
            frmInsertarInfo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmInsertarInfo);
            frmInsertarInfo.BringToFront();
            frmInsertarInfo.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas frmConsultasInfo = new frmConsultas();
            frmConsultasInfo.TopLevel = false;
            frmConsultasInfo.FormBorderStyle = FormBorderStyle.None;
            frmConsultasInfo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmConsultasInfo);
            frmConsultasInfo.BringToFront();
            frmConsultasInfo.Show();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarDesdeBotonSalir = true;
            this.Close();

        }
    }
}