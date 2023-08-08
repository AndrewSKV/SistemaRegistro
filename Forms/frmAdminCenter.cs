using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SistemaRegistro.Common;

namespace SistemaRegistro
{
    public partial class frmAdminCenter : Form
    {
        public frmAdminCenter()
        {
            InitializeComponent();
        }

        private void frmAdminCenter_Load(object sender, EventArgs e)
        {


            LoadData();


        }

        private void dgvConsultaIndividual_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgvConsultaIndividual.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string newValue = cell.Value.ToString(); // Obtener el nuevo valor editado

                // Obtener el valor de la columna 'ID' de la fila editada
                string id = dgvConsultaIndividual.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

                // Actualizar la base de datos con el nuevo valor
                DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);
                databaseManager.ActualizarRegistro(cell.OwningColumn.Name, newValue, id);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Llenar DataGridView de la consulta con lo que se le indica en el TextBox de documentos
            DataTable dtRecords = new DataTable();
            DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);
            dtRecords = databaseManager.BuscarPersonasPorDocumentos(tbDocumento.Text);
            dgvConsultaIndividual.DataSource = dtRecords;
            dgvConsultaIndividual.Columns["Documento"].ReadOnly = true;
            dgvConsultaIndividual.ScrollBars = ScrollBars.Both;
        }

        private void tbDocumento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDocumento.Text))
            {
                LoadData();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);
            if (databaseManager.IngresarNuevoUsuario(tbNewUser.Text, tbNewPassword.Text, cbRoles.Text))
            {
                lbInfo.ForeColor = Color.Green;
                lbInfo.Text = "Usuario ingresado con exito";
            }
            else
            {
                lbInfo.ForeColor = Color.Red;
                lbInfo.Text = "Ocurrió un error al intentar ingresar al usuario";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNewUser.Clear();
            tbNewPassword.Clear();
            cbRoles.Text = string.Empty;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConsultaIndividual.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar la fila seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvConsultaIndividual.SelectedRows[0].Index;
                    string id = dgvConsultaIndividual.Rows[selectedRowIndex].Cells["Documento"].Value.ToString();

                    DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);
                    bool success = databaseManager.EliminarRegistro(id);


                    if (success)
                    {
                        lbInfoTR.Text = "Fila eliminada exitosamente.";
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadData()
        {
            DataTable dtAllRecords = new DataTable();
            DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);
            dtAllRecords = databaseManager.GetAllRecords();
            dgvConsultaIndividual.DataSource = dtAllRecords;
            dgvConsultaIndividual.Columns["Documento"].ReadOnly = true;
            dgvConsultaIndividual.ScrollBars = ScrollBars.Both;
        }
    }
}
