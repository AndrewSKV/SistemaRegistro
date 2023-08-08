namespace SistemaRegistro
{
    partial class frmAdminCenter
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
            lbInfo = new Label();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            cbRoles = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbNewPassword = new TextBox();
            tbNewUser = new TextBox();
            tbDocumento = new TextBox();
            label5 = new Label();
            dgvConsultaIndividual = new DataGridView();
            btnBuscar = new Button();
            label7 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbInfoTR = new Label();
            btnEliminar = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaIndividual).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lbInfo
            // 
            lbInfo.Anchor = AnchorStyles.None;
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(506, 395);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(0, 15);
            lbInfo.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.Location = new Point(695, 348);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Location = new Point(562, 348);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbRoles
            // 
            cbRoles.Anchor = AnchorStyles.None;
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(649, 285);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(121, 23);
            cbRoles.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(479, 288);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 5;
            label4.Text = "Seleccione el rol del nuevo rol:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(427, 243);
            label3.Name = "label3";
            label3.Size = new Size(219, 15);
            label3.TabIndex = 4;
            label3.Text = "Ingrese la contraseña del nuevo Usuario:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(482, 200);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el nombre de Usuario:";
            // 
            // tbNewPassword
            // 
            tbNewPassword.Anchor = AnchorStyles.None;
            tbNewPassword.Location = new Point(649, 240);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(150, 23);
            tbNewPassword.TabIndex = 2;
            tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbNewUser
            // 
            tbNewUser.Anchor = AnchorStyles.None;
            tbNewUser.Location = new Point(649, 197);
            tbNewUser.Name = "tbNewUser";
            tbNewUser.Size = new Size(150, 23);
            tbNewUser.TabIndex = 1;
            // 
            // tbDocumento
            // 
            tbDocumento.Anchor = AnchorStyles.None;
            tbDocumento.Location = new Point(415, 98);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(181, 23);
            tbDocumento.TabIndex = 5;
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(274, 101);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 6;
            label5.Text = "Numero de documento:";
            // 
            // dgvConsultaIndividual
            // 
            dgvConsultaIndividual.Anchor = AnchorStyles.None;
            dgvConsultaIndividual.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvConsultaIndividual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaIndividual.Location = new Point(209, 142);
            dgvConsultaIndividual.Name = "dgvConsultaIndividual";
            dgvConsultaIndividual.RowTemplate.Height = 25;
            dgvConsultaIndividual.Size = new Size(939, 403);
            dgvConsultaIndividual.TabIndex = 7;
            dgvConsultaIndividual.VirtualMode = true;
            dgvConsultaIndividual.CellEndEdit += dgvConsultaIndividual_CellEndEdit;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Location = new Point(602, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(691, 101);
            label7.Name = "label7";
            label7.Size = new Size(399, 15);
            label7.TabIndex = 9;
            label7.Text = "Por favor ingrese los numeros de documento a consultar separados por \",\"";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1373, 693);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientInactiveCaption;
            tabPage1.Controls.Add(lbInfoTR);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(dgvConsultaIndividual);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(tbDocumento);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1365, 665);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Todos los registros";
            // 
            // lbInfoTR
            // 
            lbInfoTR.AutoSize = true;
            lbInfoTR.Location = new Point(813, 592);
            lbInfoTR.Name = "lbInfoTR";
            lbInfoTR.Size = new Size(0, 15);
            lbInfoTR.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Location = new Point(1029, 569);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 28);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar registro";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 633);
            label1.Name = "label1";
            label1.Size = new Size(847, 15);
            label1.TabIndex = 10;
            label1.Text = "Aquí puedes editar o eliminar los registros de la tabla Personas. Si deseas eliminar un registro completo, selecciona toda la fila y dale al botón \"Eliminar registro\"";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientInactiveCaption;
            tabPage2.Controls.Add(lbInfo);
            tabPage2.Controls.Add(btnLimpiar);
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(cbRoles);
            tabPage2.Controls.Add(tbNewUser);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(tbNewPassword);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1365, 665);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Agregar un nuevo Usuario";
            // 
            // frmAdminCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1373, 693);
            Controls.Add(tabControl1);
            Name = "frmAdminCenter";
            ShowIcon = false;
            Text = "Admin Center";
            Load += frmAdminCenter_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaIndividual).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbNewPassword;
        private TextBox tbNewUser;
        private Label label3;
        private Label label2;
        private ComboBox cbRoles;
        private Label label4;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label lbInfo;
        private Label label7;
        private Button btnBuscar;
        private DataGridView dgvConsultaIndividual;
        private Label label5;
        private TextBox tbDocumento;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Button btnEliminar;
        private Label lbInfoTR;
    }
}