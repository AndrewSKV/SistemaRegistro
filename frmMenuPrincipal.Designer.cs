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
            panelPrincipal = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            nuevoRegistroToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            adminCenterToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.GradientInactiveCaption;
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(135, 150, 100, 100);
            panelPrincipal.Size = new Size(1447, 687);
            panelPrincipal.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1447, 35);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoRegistroToolStripMenuItem, consultasToolStripMenuItem, toolStripSeparator1, adminCenterToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            menuToolStripMenuItem.Margin = new Padding(5, 5, 0, 5);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(53, 21);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            nuevoRegistroToolStripMenuItem.Size = new Size(167, 22);
            nuevoRegistroToolStripMenuItem.Text = "Nuevo Registro";
            nuevoRegistroToolStripMenuItem.Click += nuevoRegistroToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(167, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            consultasToolStripMenuItem.Click += consultasToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(164, 6);
            // 
            // adminCenterToolStripMenuItem
            // 
            adminCenterToolStripMenuItem.Name = "adminCenterToolStripMenuItem";
            adminCenterToolStripMenuItem.Size = new Size(167, 22);
            adminCenterToolStripMenuItem.Text = "Admin center";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(45, 31);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // frmMenuPP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1447, 687);
            Controls.Add(menuStrip1);
            Controls.Add(panelPrincipal);
            MainMenuStrip = menuStrip1;
            Name = "frmMenuPP";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "      Sistema de Registro";
            WindowState = FormWindowState.Maximized;
            FormClosed += frmMenuPP_FormClosed;
            Load += frmMenuPP_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPrincipal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem adminCenterToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}