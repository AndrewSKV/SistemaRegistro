namespace SistemaRegistro
{
    partial class frmConsultas
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
            groupBox1 = new GroupBox();
            lbNombreMayorEdad = new Label();
            lbPromedioEdad = new Label();
            lbNumeroMujeres = new Label();
            lbNumeroHombres = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Nombres_Completos = new ListBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            btnBuscar = new Button();
            dgvConsultaIndividual = new DataGridView();
            label5 = new Label();
            tbDocumento = new TextBox();
            btnAtras = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaIndividual).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(lbNombreMayorEdad);
            groupBox1.Controls.Add(lbPromedioEdad);
            groupBox1.Controls.Add(lbNumeroMujeres);
            groupBox1.Controls.Add(lbNumeroHombres);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(57, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 94);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos pre-cargados";
            // 
            // lbNombreMayorEdad
            // 
            lbNombreMayorEdad.AutoSize = true;
            lbNombreMayorEdad.Location = new Point(243, 64);
            lbNombreMayorEdad.Name = "lbNombreMayorEdad";
            lbNombreMayorEdad.Size = new Size(0, 15);
            lbNombreMayorEdad.TabIndex = 7;
            // 
            // lbPromedioEdad
            // 
            lbPromedioEdad.AutoSize = true;
            lbPromedioEdad.Location = new Point(622, 19);
            lbPromedioEdad.Name = "lbPromedioEdad";
            lbPromedioEdad.Size = new Size(0, 15);
            lbPromedioEdad.TabIndex = 6;
            // 
            // lbNumeroMujeres
            // 
            lbNumeroMujeres.AutoSize = true;
            lbNumeroMujeres.Location = new Point(425, 19);
            lbNumeroMujeres.Name = "lbNumeroMujeres";
            lbNumeroMujeres.Size = new Size(0, 15);
            lbNumeroMujeres.TabIndex = 5;
            // 
            // lbNumeroHombres
            // 
            lbNumeroHombres.AutoSize = true;
            lbNumeroHombres.Location = new Point(184, 19);
            lbNumeroHombres.Name = "lbNumeroHombres";
            lbNumeroHombres.Size = new Size(0, 15);
            lbNumeroHombres.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(497, 19);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 3;
            label4.Text = "Promedio de la edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 64);
            label3.Name = "label3";
            label3.Size = new Size(216, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre de la persona con mayor edad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(254, 19);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de Mujeres en la BD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(172, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de Hombres en la BD:";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 112);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(844, 429);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientInactiveCaption;
            tabPage1.Controls.Add(Nombres_Completos);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(836, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Todos los nombres";
            // 
            // Nombres_Completos
            // 
            Nombres_Completos.FormattingEnabled = true;
            Nombres_Completos.ItemHeight = 15;
            Nombres_Completos.Location = new Point(324, 6);
            Nombres_Completos.Name = "Nombres_Completos";
            Nombres_Completos.Size = new Size(208, 379);
            Nombres_Completos.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 6);
            label6.Name = "label6";
            label6.Size = new Size(238, 45);
            label6.TabIndex = 1;
            label6.Text = "Aquí puedes visualizar el nombre completo \r\nde todas las personas que\r\nestán registradas en la base de datos";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientInactiveCaption;
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnBuscar);
            tabPage2.Controls.Add(dgvConsultaIndividual);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tbDocumento);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(836, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta por documentos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(423, 17);
            label7.Name = "label7";
            label7.Size = new Size(399, 15);
            label7.TabIndex = 4;
            label7.Text = "Por favor ingrese los numeros de documento a consultar separados por \",\"";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(334, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvConsultaIndividual
            // 
            dgvConsultaIndividual.BackgroundColor = SystemColors.Control;
            dgvConsultaIndividual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaIndividual.Location = new Point(6, 55);
            dgvConsultaIndividual.Name = "dgvConsultaIndividual";
            dgvConsultaIndividual.ReadOnly = true;
            dgvConsultaIndividual.RowTemplate.Height = 25;
            dgvConsultaIndividual.Size = new Size(824, 340);
            dgvConsultaIndividual.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 17);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 1;
            label5.Text = "Numero de documento:";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(147, 14);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(181, 23);
            tbDocumento.TabIndex = 0;
            // 
            // btnAtras
            // 
            btnAtras.Anchor = AnchorStyles.None;
            btnAtras.Location = new Point(763, 46);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(868, 553);
            ControlBox = false;
            Controls.Add(btnAtras);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Name = "frmConsultas";
            Text = "Consultas";
            Load += frmConsultas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaIndividual).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private TextBox tbDocumento;
        private Label label6;
        private DataGridView dgvConsultaIndividual;
        private Button btnBuscar;
        private ListBox Nombres_Completos;
        private Label lbNombreMayorEdad;
        private Label lbPromedioEdad;
        private Label lbNumeroMujeres;
        private Label lbNumeroHombres;
        private Label label7;
        private Button btnAtras;
    }
}