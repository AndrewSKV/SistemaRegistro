namespace SistemaRegistro
{
    partial class frmInsertar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblText = new Label();
            grbInfo = new GroupBox();
            cbGenero = new ComboBox();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            tbEdad = new TextBox();
            label10 = new Label();
            label9 = new Label();
            tbDireccion = new TextBox();
            label8 = new Label();
            tbCorreo = new TextBox();
            label7 = new Label();
            tbTelefono = new TextBox();
            label6 = new Label();
            tbSegundoApellido = new TextBox();
            label5 = new Label();
            tbPrimerApellido = new TextBox();
            tbSegundoNombre = new TextBox();
            tbPrimerNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbDocumento = new TextBox();
            label1 = new Label();
            lblAlert = new Label();
            grbInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.Anchor = AnchorStyles.None;
            lblText.AutoSize = true;
            lblText.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblText.Location = new Point(117, 42);
            lblText.Name = "lblText";
            lblText.Size = new Size(384, 20);
            lblText.TabIndex = 0;
            lblText.Text = "Ingresa los datos de la persona a insertar en los registros";
            // 
            // grbInfo
            // 
            grbInfo.Anchor = AnchorStyles.None;
            grbInfo.Controls.Add(cbGenero);
            grbInfo.Controls.Add(btnLimpiar);
            grbInfo.Controls.Add(btnGuardar);
            grbInfo.Controls.Add(tbEdad);
            grbInfo.Controls.Add(label10);
            grbInfo.Controls.Add(label9);
            grbInfo.Controls.Add(tbDireccion);
            grbInfo.Controls.Add(label8);
            grbInfo.Controls.Add(tbCorreo);
            grbInfo.Controls.Add(label7);
            grbInfo.Controls.Add(tbTelefono);
            grbInfo.Controls.Add(label6);
            grbInfo.Controls.Add(tbSegundoApellido);
            grbInfo.Controls.Add(label5);
            grbInfo.Controls.Add(tbPrimerApellido);
            grbInfo.Controls.Add(tbSegundoNombre);
            grbInfo.Controls.Add(tbPrimerNombre);
            grbInfo.Controls.Add(label4);
            grbInfo.Controls.Add(label3);
            grbInfo.Controls.Add(label2);
            grbInfo.Controls.Add(tbDocumento);
            grbInfo.Controls.Add(label1);
            grbInfo.Location = new Point(12, 124);
            grbInfo.Name = "grbInfo";
            grbInfo.Size = new Size(633, 402);
            grbInfo.TabIndex = 2;
            grbInfo.TabStop = false;
            grbInfo.Text = "Recuerde: Los campos marcados con (*) son OBLIGATORIOS";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cbGenero.Location = new Point(26, 319);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(147, 23);
            cbGenero.TabIndex = 22;
            cbGenero.SelectedIndexChanged += cbGenero_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(482, 331);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(371, 331);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(388, 265);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(147, 23);
            tbEdad.TabIndex = 17;
            tbEdad.TextChanged += tbEdad_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 301);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 16;
            label10.Text = "Género*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(388, 247);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 16;
            label9.Text = "Edad*";
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(26, 265);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(147, 23);
            tbDireccion.TabIndex = 15;
            tbDireccion.TextChanged += tbDireccion_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 247);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 14;
            label8.Text = "Dirección*";
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(388, 212);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(147, 23);
            tbCorreo.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(388, 194);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 12;
            label7.Text = "Correo";
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(26, 212);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(147, 23);
            tbTelefono.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 194);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Teléfono";
            // 
            // tbSegundoApellido
            // 
            tbSegundoApellido.Location = new Point(388, 158);
            tbSegundoApellido.Name = "tbSegundoApellido";
            tbSegundoApellido.Size = new Size(147, 23);
            tbSegundoApellido.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 140);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 8;
            label5.Text = "Segundo Apellido";
            // 
            // tbPrimerApellido
            // 
            tbPrimerApellido.Location = new Point(26, 158);
            tbPrimerApellido.Name = "tbPrimerApellido";
            tbPrimerApellido.Size = new Size(147, 23);
            tbPrimerApellido.TabIndex = 7;
            tbPrimerApellido.TextChanged += tbPrimerApellido_TextChanged;
            // 
            // tbSegundoNombre
            // 
            tbSegundoNombre.Location = new Point(388, 101);
            tbSegundoNombre.Name = "tbSegundoNombre";
            tbSegundoNombre.Size = new Size(147, 23);
            tbSegundoNombre.TabIndex = 6;
            // 
            // tbPrimerNombre
            // 
            tbPrimerNombre.Location = new Point(26, 100);
            tbPrimerNombre.Name = "tbPrimerNombre";
            tbPrimerNombre.Size = new Size(147, 23);
            tbPrimerNombre.TabIndex = 5;
            tbPrimerNombre.TextChanged += tbPrimerNombre_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 140);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 4;
            label4.Text = "Primer Apellido*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 82);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 3;
            label3.Text = "Segundo Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(26, 82);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Primer Nombre*";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(26, 45);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(147, 23);
            tbDocumento.TabIndex = 1;
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Número documento*";
            // 
            // lblAlert
            // 
            lblAlert.AutoSize = true;
            lblAlert.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlert.ForeColor = Color.Red;
            lblAlert.Location = new Point(12, 529);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(0, 15);
            lblAlert.TabIndex = 21;
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(657, 653);
            ControlBox = false;
            Controls.Add(lblAlert);
            Controls.Add(grbInfo);
            Controls.Add(lblText);
            Name = "frmInsertar";
            Text = "Insertar Nuevo Registro";
            Load += frmInsertar_Load;
            grbInfo.ResumeLayout(false);
            grbInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private GroupBox grbInfo;
        private TextBox tbPrimerNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbDocumento;
        private Label label1;
        private TextBox tbPrimerApellido;
        private TextBox tbSegundoNombre;
        private TextBox tbDireccion;
        private Label label8;
        private TextBox tbCorreo;
        private Label label7;
        private TextBox tbTelefono;
        private Label label6;
        private TextBox tbSegundoApellido;
        private Label label5;
        private TextBox tbEdad;
        private Label label9;
        private Label label10;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label lblAlert;
        private ComboBox cbGenero;
    }
}