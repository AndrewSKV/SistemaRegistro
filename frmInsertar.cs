using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRegistro
{
    public partial class frmInsertar : Form
    {
        private StringBuilder mensajesError;

        public frmInsertar()
        {
            InitializeComponent();
            mensajesError = new StringBuilder();
        }

        private void frmInsertar_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbCorreo.Clear();
            tbDireccion.Clear();
            tbDocumento.Clear();
            tbEdad.Clear();
            cbGenero.Text = string.Empty;
            tbPrimerApellido.Clear();
            tbPrimerNombre.Clear();
            tbSegundoApellido.Clear();
            tbSegundoNombre.Clear();
            tbTelefono.Clear();
            lblAlert.Text = string.Empty;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Limpiar los mensajes de error acumulados
            lblAlert.ForeColor = Color.Red;
            mensajesError.Clear();

            // Validar cada campo y acumular los mensajes de error si es necesario
            if (!ValidacionDatos.ValidarEdad(tbEdad.Text))
            {
                mensajesError.AppendLine("En el campo Edad, ingrese un número entero positivo válido.");
            }

            if (!ValidacionDatos.ValidarDocumento(tbDocumento.Text))
            {
                mensajesError.AppendLine("En el campo Documento, ingrese un documento válido");
            }

            if (!ValidacionDatos.ValidarPrimerNombre(tbPrimerNombre.Text))
            {
                mensajesError.AppendLine("En el campo Primer Nombre, ingrese un valor válido que no contenga números.");
            }

            if (!ValidacionDatos.ValidarPrimerApellido(tbPrimerApellido.Text))
            {
                mensajesError.AppendLine("En el campo Primer Apellido, ingrese un valor válido que no contenga números.");
            }

            if (!ValidacionDatos.ValidarDireccion(tbDireccion.Text))
            {
                mensajesError.AppendLine("El campo Dirección no puede estar vacío.");
            }

            if (!ValidacionDatos.ValidarGenero(cbGenero.SelectedItem.ToString()))
            {
                mensajesError.AppendLine("En el campo Género, ingrese un valor válido que no contenga números.");
            }

            // Mostrar los mensajes de error en el Label
            lblAlert.Text = mensajesError.ToString();

            DatabaseManager databaseManager = new DatabaseManager(DatabaseManager.RutaDB); // Pasar la conexión como argumento al constructor
            // Si no hay mensajes de error, crear Persona

            if (!databaseManager.ValidarDocumentoExistente(tbDocumento.Text))
            {
                if (mensajesError.Length == 0)
                {
                    Persona nuevaPersona = new Persona(
                        tbDocumento.Text,
                        tbPrimerNombre.Text,
                        tbPrimerApellido.Text,
                        tbSegundoNombre.Text,
                        tbSegundoApellido.Text,
                        tbTelefono.Text,
                        tbCorreo.Text,
                        tbDireccion.Text,
                        int.Parse(tbEdad.Text), // Aquí asumimos que la validación de edad fue exitosa, así que podemos convertir el texto a int
                        cbGenero.SelectedItem.ToString()
                        );

                    // Insertar la nueva persona en la base de datos

                    bool result = databaseManager.InsertarPersona(nuevaPersona);
                    if (result)
                    {

                        lblAlert.Text = string.Empty;
                        lblAlert.ForeColor = Color.Green;
                        lblAlert.Text = "Persona guardada correctamente";

                    }
                }

            }
            else { lblAlert.Text = "El número de documento que ingresó ya se encuentra en la base de datos"; }
        }

        private void tbDocumento_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardarButton();
        }

        private void tbPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardarButton();
        }

        private void tbPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardarButton();
        }

        private void tbDireccion_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardarButton();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarGuardarButton();
        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {
            HabilitarGuardarButton();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenuPP frmMenu = new frmMenuPP();
            this.Close();
            frmMenu.Show();

        }

        private void HabilitarGuardarButton()
        {
            // Verificar si todos los campos obligatorios están diligenciados
            bool todosCamposCompletos =
                !ValidacionDatos.EsCampoVacio(tbDocumento.Text) &&
                !ValidacionDatos.EsCampoVacio(tbPrimerNombre.Text) &&
                !ValidacionDatos.EsCampoVacio(tbPrimerApellido.Text) &&
                !ValidacionDatos.EsCampoVacio(tbEdad.Text) &&
                !ValidacionDatos.EsCampoVacio(cbGenero.SelectedItem.ToString()) &&
                !ValidacionDatos.EsCampoVacio(tbDireccion.Text);

            // Habilitar/deshabilitar el botón Guardar según el resultado de la validación
            btnGuardar.Enabled = todosCamposCompletos;
        }


    }
}
