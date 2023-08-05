using System;
using System.Windows.Forms;
namespace SistemaRegistro
{
    public partial class frmMenuPP : Form
    {
        public frmMenuPP()
        {
            InitializeComponent();
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertar frmInsertarInfo = new frmInsertar();
            frmInsertarInfo.Show();
            this.Hide();

        }

        private void frmMenuPP_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuPP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            frmConsultas frmConsultasInfo = new frmConsultas(); 
            frmConsultasInfo.Show();    
            this.Hide();
        }
    }
}