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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {

            InitializeComponent();

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            DataTable dtAllRecords = new DataTable();
            DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);
            dtAllRecords = databaseManager.GetAllRecords();

            //Llenar ListBox Nombres_Completos con todos los registros
            foreach (DataRow dr in dtAllRecords.Rows)
            {
                Nombres_Completos.Items.Add(dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4]);
            }

            //Consulta 1: Nombre de la persona con mayor edad
            lbNombreMayorEdad.Text = dtAllRecords.AsEnumerable()
            .OrderByDescending(row => row.Field<long>("Edad"))
            .Select(row => $"{row.Field<string>("PrimerNombre")} {row.Field<string>("PrimerApellido")}")
            .FirstOrDefault();

            //Consulta 2: Cuantas mujeres hay
            lbNumeroMujeres.Text = dtAllRecords.AsEnumerable().Count(row => row.Field<string>("Genero") == "Femenino").ToString();

            // Consulta 3: Cuántos hombres hay
            lbNumeroHombres.Text = dtAllRecords.AsEnumerable().Count(row => row.Field<string>("Genero") == "Masculino").ToString();

            // Consulta 4: Promedio Edad
            lbPromedioEdad.Text = dtAllRecords.AsEnumerable().Average(row => row.Field<long>("Edad")).ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Llenar DataGridView de la consulta con lo que se le indica en el TextBox de documento
            DataTable dtRecords = new DataTable();
            DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB);
            dtRecords = databaseManager.BuscarPersonasPorDocumentos(tbDocumento.Text);
            dgvConsultaIndividual.DataSource = dtRecords;
            dgvConsultaIndividual.ScrollBars = ScrollBars.Both;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenuPP frmMenu = new frmMenuPP();
            this.Close();
            frmMenu.Show();

        }
    }
}
