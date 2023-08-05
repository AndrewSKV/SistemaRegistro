namespace SistemaRegistro
{
    partial class frmMenuPP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnConsultas = new Button();
            btnInsertar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 22);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 0;
            label1.Text = "Por favor, elije una opción";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConsultas
            // 
            btnConsultas.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultas.Location = new Point(96, 163);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(180, 29);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertar.Location = new Point(96, 106);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(180, 30);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar Nuevo Registro";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmMenuPP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 272);
            Controls.Add(btnInsertar);
            Controls.Add(btnConsultas);
            Controls.Add(label1);
            Name = "frmMenuPP";
            ShowIcon = false;
            Text = "Menu Principal";
            FormClosed += frmMenuPP_FormClosed;
            Load += frmMenuPP_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConsultas;
        private Button btnInsertar;
    }
}