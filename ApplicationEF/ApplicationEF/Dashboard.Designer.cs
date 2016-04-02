namespace ApplicationEF
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anexosEscolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MDI = new System.Windows.Forms.Panel();
            this.examenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.White;
            this.Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.examenToolStripMenuItem,
            this.blacklistToolStripMenuItem,
            this.maquinaToolStripMenuItem,
            this.responsableToolStripMenuItem,
            this.anexosEscolaresToolStripMenuItem});
            this.Main.Location = new System.Drawing.Point(20, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(760, 24);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // blacklistToolStripMenuItem
            // 
            this.blacklistToolStripMenuItem.Name = "blacklistToolStripMenuItem";
            this.blacklistToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.blacklistToolStripMenuItem.Text = "Blacklist";
            this.blacklistToolStripMenuItem.Click += new System.EventHandler(this.blacklistToolStripMenuItem_Click);
            // 
            // maquinaToolStripMenuItem
            // 
            this.maquinaToolStripMenuItem.Name = "maquinaToolStripMenuItem";
            this.maquinaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.maquinaToolStripMenuItem.Text = "Maquina";
            this.maquinaToolStripMenuItem.Click += new System.EventHandler(this.maquinaToolStripMenuItem_Click);
            // 
            // responsableToolStripMenuItem
            // 
            this.responsableToolStripMenuItem.Name = "responsableToolStripMenuItem";
            this.responsableToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.responsableToolStripMenuItem.Text = "Responsable";
            this.responsableToolStripMenuItem.Click += new System.EventHandler(this.responsableToolStripMenuItem_Click);
            // 
            // anexosEscolaresToolStripMenuItem
            // 
            this.anexosEscolaresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.asignaturaToolStripMenuItem,
            this.grupoToolStripMenuItem,
            this.turnoToolStripMenuItem});
            this.anexosEscolaresToolStripMenuItem.Name = "anexosEscolaresToolStripMenuItem";
            this.anexosEscolaresToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.anexosEscolaresToolStripMenuItem.Text = "Anexos Escolares";
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.docenteToolStripMenuItem.Text = "Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // asignaturaToolStripMenuItem
            // 
            this.asignaturaToolStripMenuItem.Name = "asignaturaToolStripMenuItem";
            this.asignaturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asignaturaToolStripMenuItem.Text = "Asignatura";
            this.asignaturaToolStripMenuItem.Click += new System.EventHandler(this.asignaturaToolStripMenuItem_Click);
            // 
            // grupoToolStripMenuItem
            // 
            this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            this.grupoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grupoToolStripMenuItem.Text = "Grupo";
            this.grupoToolStripMenuItem.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.turnoToolStripMenuItem.Text = "Turno";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.MDI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MDI.Location = new System.Drawing.Point(20, 84);
            this.MDI.Name = "MDI";
            this.MDI.Size = new System.Drawing.Size(760, 496);
            this.MDI.TabIndex = 1;
            // 
            // examenToolStripMenuItem
            // 
            this.examenToolStripMenuItem.Name = "examenToolStripMenuItem";
            this.examenToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.examenToolStripMenuItem.Text = "Examen";
            this.examenToolStripMenuItem.Click += new System.EventHandler(this.examenToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.MDI);
            this.Controls.Add(this.Main);
            this.MainMenuStrip = this.Main;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Dashboard";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Dashboard";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main;
        private System.Windows.Forms.Panel MDI;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blacklistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maquinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anexosEscolaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenToolStripMenuItem;
    }
}

