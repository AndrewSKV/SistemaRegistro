namespace SistemaRegistro
{
    partial class frmInicioSesion
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
            btnIniciar = new Button();
            tbPassword = new TextBox();
            tbUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lbInfo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.Enabled = false;
            btnIniciar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(242, 232);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(100, 26);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.None;
            tbPassword.BackColor = Color.Gainsboro;
            tbPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(199, 174);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(200, 27);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += tbContraseña_TextChanged;
            // 
            // tbUsuario
            // 
            tbUsuario.Anchor = AnchorStyles.None;
            tbUsuario.BackColor = Color.Gainsboro;
            tbUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsuario.Location = new Point(201, 107);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(200, 27);
            tbUsuario.TabIndex = 3;
            tbUsuario.TextChanged += tbUsuario_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 80);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(199, 151);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbInfo);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsuario);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(50);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 411);
            panel1.TabIndex = 6;
            // 
            // lbInfo
            // 
            lbInfo.Anchor = AnchorStyles.None;
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbInfo.ForeColor = Color.Red;
            lbInfo.Location = new Point(58, 316);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(0, 17);
            lbInfo.TabIndex = 6;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(618, 411);
            Controls.Add(panel1);
            Name = "frmInicioSesion";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inicio Sesión";
            FormClosed += frmInicioSesion_FormClosed;
            Load += frmInicioSesion_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private TextBox tbPassword;
        private TextBox tbUsuario;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label lbInfo;
    }
}