using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistro
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);


            if (databaseManager.VerificarUsuario(tbUsuario.Text) & databaseManager.VerificarPassword(tbPassword.Text))
            {
                frmMenuPP frmMenuPP = new frmMenuPP();
                frmMenuPP.Show();
                this.Hide();
            }
            else
            {
                lbInfo.Text = "Usuario o contraseña incorrectos, por favor verifique e intente de nuevo";
            }

        }

        private void HabilitarInicioButton()
        {
            // Verificar si todos los campos obligatorios están diligenciados
            bool todosCamposCompletos =
                !ValidacionDatos.EsCampoVacio(tbUsuario.Text) &&
                !ValidacionDatos.EsCampoVacio(tbPassword.Text);

            // Habilitar/deshabilitar el botón Inicio según el resultado de la validación
            btnIniciar.Enabled = todosCamposCompletos;
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            HabilitarInicioButton();
        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {
            HabilitarInicioButton();
        }

        private void frmInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
