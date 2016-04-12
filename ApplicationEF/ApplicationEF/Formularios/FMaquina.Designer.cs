namespace ApplicationEF.Formularios
{
    partial class FMaquina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Grid = new MetroFramework.Controls.MetroGrid();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.panel1Agregar = new MetroFramework.Controls.MetroTabPage();
            this.tab1cbRAM = new System.Windows.Forms.ComboBox();
            this.tab1cbHDD = new System.Windows.Forms.ComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tab1tbModelo = new System.Windows.Forms.TextBox();
            this.tab1tbCPU = new System.Windows.Forms.TextBox();
            this.tab1tbGPU = new System.Windows.Forms.TextBox();
            this.tab1btAgregar = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tab1tbFabricante = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tab1tbID = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2Modificar = new MetroFramework.Controls.MetroTabPage();
            this.tab2cbHDD = new System.Windows.Forms.ComboBox();
            this.tab2cbRAM = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tab2tbModelo = new System.Windows.Forms.TextBox();
            this.tab2tbCPU = new System.Windows.Forms.TextBox();
            this.tab2tbGPU = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tab2tbFabricante = new System.Windows.Forms.TextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tab2tbID = new System.Windows.Forms.TextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.tab2btModificar = new MetroFramework.Controls.MetroTile();
            this.panel3Eliminar = new MetroFramework.Controls.MetroTabPage();
            this.tab3btEliminar = new MetroFramework.Controls.MetroTile();
            this.tab3tbID = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.TabControl.SuspendLayout();
            this.panel1Agregar.SuspendLayout();
            this.panel2Modificar.SuspendLayout();
            this.panel3Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.Grid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TabControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 561);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle14;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid.Location = new System.Drawing.Point(238, 61);
            this.Grid.Margin = new System.Windows.Forms.Padding(5);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(341, 242);
            this.Grid.TabIndex = 3;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.panel1Agregar);
            this.TabControl.Controls.Add(this.panel2Modificar);
            this.TabControl.Controls.Add(this.panel3Eliminar);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 59);
            this.TabControl.Name = "TabControl";
            this.tableLayoutPanel1.SetRowSpan(this.TabControl, 2);
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(227, 499);
            this.TabControl.TabIndex = 1;
            this.TabControl.UseSelectable = true;
            // 
            // panel1Agregar
            // 
            this.panel1Agregar.Controls.Add(this.tab1cbRAM);
            this.panel1Agregar.Controls.Add(this.tab1cbHDD);
            this.panel1Agregar.Controls.Add(this.metroLabel12);
            this.panel1Agregar.Controls.Add(this.metroLabel11);
            this.panel1Agregar.Controls.Add(this.metroLabel10);
            this.panel1Agregar.Controls.Add(this.tab1tbModelo);
            this.panel1Agregar.Controls.Add(this.tab1tbCPU);
            this.panel1Agregar.Controls.Add(this.tab1tbGPU);
            this.panel1Agregar.Controls.Add(this.tab1btAgregar);
            this.panel1Agregar.Controls.Add(this.metroLabel4);
            this.panel1Agregar.Controls.Add(this.metroLabel3);
            this.panel1Agregar.Controls.Add(this.tab1tbFabricante);
            this.panel1Agregar.Controls.Add(this.metroLabel2);
            this.panel1Agregar.Controls.Add(this.tab1tbID);
            this.panel1Agregar.Controls.Add(this.metroLabel1);
            this.panel1Agregar.HorizontalScrollbarBarColor = true;
            this.panel1Agregar.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1Agregar.HorizontalScrollbarSize = 10;
            this.panel1Agregar.Location = new System.Drawing.Point(4, 38);
            this.panel1Agregar.Name = "panel1Agregar";
            this.panel1Agregar.Size = new System.Drawing.Size(219, 457);
            this.panel1Agregar.TabIndex = 0;
            this.panel1Agregar.Text = "Agregar";
            this.panel1Agregar.VerticalScrollbarBarColor = true;
            this.panel1Agregar.VerticalScrollbarHighlightOnWheel = false;
            this.panel1Agregar.VerticalScrollbarSize = 10;
            // 
            // tab1cbRAM
            // 
            this.tab1cbRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1cbRAM.FormattingEnabled = true;
            this.tab1cbRAM.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.tab1cbRAM.Location = new System.Drawing.Point(6, 215);
            this.tab1cbRAM.Name = "tab1cbRAM";
            this.tab1cbRAM.Size = new System.Drawing.Size(210, 21);
            this.tab1cbRAM.TabIndex = 20;
            // 
            // tab1cbHDD
            // 
            this.tab1cbHDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1cbHDD.FormattingEnabled = true;
            this.tab1cbHDD.Items.AddRange(new object[] {
            "160",
            "250",
            "320",
            "360",
            "500",
            "640",
            "750",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000"});
            this.tab1cbHDD.Location = new System.Drawing.Point(6, 309);
            this.tab1cbHDD.Name = "tab1cbHDD";
            this.tab1cbHDD.Size = new System.Drawing.Size(210, 21);
            this.tab1cbHDD.TabIndex = 19;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(6, 286);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(65, 19);
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "HDD (GB)";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(6, 192);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "RAM (GB)";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 239);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(35, 19);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "GPU";
            // 
            // tab1tbModelo
            // 
            this.tab1tbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1tbModelo.Location = new System.Drawing.Point(6, 121);
            this.tab1tbModelo.Name = "tab1tbModelo";
            this.tab1tbModelo.Size = new System.Drawing.Size(210, 20);
            this.tab1tbModelo.TabIndex = 14;
            // 
            // tab1tbCPU
            // 
            this.tab1tbCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1tbCPU.Location = new System.Drawing.Point(6, 168);
            this.tab1tbCPU.Name = "tab1tbCPU";
            this.tab1tbCPU.Size = new System.Drawing.Size(210, 20);
            this.tab1tbCPU.TabIndex = 13;
            // 
            // tab1tbGPU
            // 
            this.tab1tbGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1tbGPU.Location = new System.Drawing.Point(6, 262);
            this.tab1tbGPU.Name = "tab1tbGPU";
            this.tab1tbGPU.Size = new System.Drawing.Size(210, 20);
            this.tab1tbGPU.TabIndex = 12;
            // 
            // tab1btAgregar
            // 
            this.tab1btAgregar.ActiveControl = null;
            this.tab1btAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1btAgregar.Location = new System.Drawing.Point(6, 333);
            this.tab1btAgregar.Name = "tab1btAgregar";
            this.tab1btAgregar.Size = new System.Drawing.Size(210, 30);
            this.tab1btAgregar.Style = MetroFramework.MetroColorStyle.Green;
            this.tab1btAgregar.TabIndex = 10;
            this.tab1btAgregar.Text = "Agregar";
            this.tab1btAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tab1btAgregar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tab1btAgregar.UseSelectable = true;
            this.tab1btAgregar.Click += new System.EventHandler(this.tab1btAgregar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "CPU";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Modelo";
            // 
            // tab1tbFabricante
            // 
            this.tab1tbFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1tbFabricante.Location = new System.Drawing.Point(6, 74);
            this.tab1tbFabricante.Name = "tab1tbFabricante";
            this.tab1tbFabricante.Size = new System.Drawing.Size(210, 20);
            this.tab1tbFabricante.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Fabricante";
            // 
            // tab1tbID
            // 
            this.tab1tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1tbID.Location = new System.Drawing.Point(6, 27);
            this.tab1tbID.Name = "tab1tbID";
            this.tab1tbID.Size = new System.Drawing.Size(210, 20);
            this.tab1tbID.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID";
            // 
            // panel2Modificar
            // 
            this.panel2Modificar.Controls.Add(this.tab2cbHDD);
            this.panel2Modificar.Controls.Add(this.tab2cbRAM);
            this.panel2Modificar.Controls.Add(this.metroLabel5);
            this.panel2Modificar.Controls.Add(this.metroLabel6);
            this.panel2Modificar.Controls.Add(this.metroLabel7);
            this.panel2Modificar.Controls.Add(this.tab2tbModelo);
            this.panel2Modificar.Controls.Add(this.tab2tbCPU);
            this.panel2Modificar.Controls.Add(this.tab2tbGPU);
            this.panel2Modificar.Controls.Add(this.metroLabel8);
            this.panel2Modificar.Controls.Add(this.metroLabel13);
            this.panel2Modificar.Controls.Add(this.tab2tbFabricante);
            this.panel2Modificar.Controls.Add(this.metroLabel14);
            this.panel2Modificar.Controls.Add(this.tab2tbID);
            this.panel2Modificar.Controls.Add(this.metroLabel15);
            this.panel2Modificar.Controls.Add(this.tab2btModificar);
            this.panel2Modificar.HorizontalScrollbarBarColor = true;
            this.panel2Modificar.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2Modificar.HorizontalScrollbarSize = 10;
            this.panel2Modificar.Location = new System.Drawing.Point(4, 38);
            this.panel2Modificar.Name = "panel2Modificar";
            this.panel2Modificar.Size = new System.Drawing.Size(219, 457);
            this.panel2Modificar.TabIndex = 1;
            this.panel2Modificar.Text = "Modificar";
            this.panel2Modificar.VerticalScrollbarBarColor = true;
            this.panel2Modificar.VerticalScrollbarHighlightOnWheel = false;
            this.panel2Modificar.VerticalScrollbarSize = 10;
            // 
            // tab2cbHDD
            // 
            this.tab2cbHDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2cbHDD.FormattingEnabled = true;
            this.tab2cbHDD.Items.AddRange(new object[] {
            "160",
            "250",
            "320",
            "360",
            "500",
            "640",
            "750",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000"});
            this.tab2cbHDD.Location = new System.Drawing.Point(6, 309);
            this.tab2cbHDD.Name = "tab2cbHDD";
            this.tab2cbHDD.Size = new System.Drawing.Size(210, 21);
            this.tab2cbHDD.TabIndex = 34;
            // 
            // tab2cbRAM
            // 
            this.tab2cbRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2cbRAM.FormattingEnabled = true;
            this.tab2cbRAM.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.tab2cbRAM.Location = new System.Drawing.Point(6, 215);
            this.tab2cbRAM.Name = "tab2cbRAM";
            this.tab2cbRAM.Size = new System.Drawing.Size(210, 21);
            this.tab2cbRAM.TabIndex = 33;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 286);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "HDD (GB)";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 192);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "RAM (GB)";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 239);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "GPU";
            // 
            // tab2tbModelo
            // 
            this.tab2tbModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2tbModelo.Location = new System.Drawing.Point(6, 121);
            this.tab2tbModelo.Name = "tab2tbModelo";
            this.tab2tbModelo.Size = new System.Drawing.Size(210, 20);
            this.tab2tbModelo.TabIndex = 28;
            // 
            // tab2tbCPU
            // 
            this.tab2tbCPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2tbCPU.Location = new System.Drawing.Point(6, 168);
            this.tab2tbCPU.Name = "tab2tbCPU";
            this.tab2tbCPU.Size = new System.Drawing.Size(210, 20);
            this.tab2tbCPU.TabIndex = 27;
            // 
            // tab2tbGPU
            // 
            this.tab2tbGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2tbGPU.Location = new System.Drawing.Point(6, 262);
            this.tab2tbGPU.Name = "tab2tbGPU";
            this.tab2tbGPU.Size = new System.Drawing.Size(210, 20);
            this.tab2tbGPU.TabIndex = 26;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 145);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(35, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "CPU";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(6, 98);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(55, 19);
            this.metroLabel13.TabIndex = 23;
            this.metroLabel13.Text = "Modelo";
            // 
            // tab2tbFabricante
            // 
            this.tab2tbFabricante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2tbFabricante.Location = new System.Drawing.Point(6, 74);
            this.tab2tbFabricante.Name = "tab2tbFabricante";
            this.tab2tbFabricante.Size = new System.Drawing.Size(210, 20);
            this.tab2tbFabricante.TabIndex = 22;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(6, 51);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(69, 19);
            this.metroLabel14.TabIndex = 21;
            this.metroLabel14.Text = "Fabricante";
            // 
            // tab2tbID
            // 
            this.tab2tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2tbID.Location = new System.Drawing.Point(6, 27);
            this.tab2tbID.Name = "tab2tbID";
            this.tab2tbID.Size = new System.Drawing.Size(210, 20);
            this.tab2tbID.TabIndex = 20;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(6, 4);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(21, 19);
            this.metroLabel15.TabIndex = 19;
            this.metroLabel15.Text = "ID";
            // 
            // tab2btModificar
            // 
            this.tab2btModificar.ActiveControl = null;
            this.tab2btModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab2btModificar.Location = new System.Drawing.Point(6, 333);
            this.tab2btModificar.Name = "tab2btModificar";
            this.tab2btModificar.Size = new System.Drawing.Size(210, 30);
            this.tab2btModificar.Style = MetroFramework.MetroColorStyle.Green;
            this.tab2btModificar.TabIndex = 11;
            this.tab2btModificar.Text = "Modificar";
            this.tab2btModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tab2btModificar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tab2btModificar.UseSelectable = true;
            this.tab2btModificar.Click += new System.EventHandler(this.tab2btModificar_Click);
            // 
            // panel3Eliminar
            // 
            this.panel3Eliminar.Controls.Add(this.tab3btEliminar);
            this.panel3Eliminar.Controls.Add(this.tab3tbID);
            this.panel3Eliminar.Controls.Add(this.metroLabel9);
            this.panel3Eliminar.HorizontalScrollbarBarColor = true;
            this.panel3Eliminar.HorizontalScrollbarHighlightOnWheel = false;
            this.panel3Eliminar.HorizontalScrollbarSize = 10;
            this.panel3Eliminar.Location = new System.Drawing.Point(4, 38);
            this.panel3Eliminar.Name = "panel3Eliminar";
            this.panel3Eliminar.Size = new System.Drawing.Size(219, 457);
            this.panel3Eliminar.TabIndex = 2;
            this.panel3Eliminar.Text = "Eliminar";
            this.panel3Eliminar.VerticalScrollbarBarColor = true;
            this.panel3Eliminar.VerticalScrollbarHighlightOnWheel = false;
            this.panel3Eliminar.VerticalScrollbarSize = 10;
            // 
            // tab3btEliminar
            // 
            this.tab3btEliminar.ActiveControl = null;
            this.tab3btEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab3btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab3btEliminar.Location = new System.Drawing.Point(9, 52);
            this.tab3btEliminar.Name = "tab3btEliminar";
            this.tab3btEliminar.Size = new System.Drawing.Size(210, 30);
            this.tab3btEliminar.Style = MetroFramework.MetroColorStyle.Red;
            this.tab3btEliminar.TabIndex = 13;
            this.tab3btEliminar.Text = "Eliminar";
            this.tab3btEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tab3btEliminar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tab3btEliminar.UseSelectable = true;
            this.tab3btEliminar.Click += new System.EventHandler(this.tab3btEliminar_Click);
            // 
            // tab3tbID
            // 
            this.tab3tbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab3tbID.Location = new System.Drawing.Point(6, 26);
            this.tab3tbID.Name = "tab3tbID";
            this.tab3tbID.Size = new System.Drawing.Size(210, 20);
            this.tab3tbID.TabIndex = 12;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 4);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(21, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Máquina";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FMaquina";
            this.Text = "FMaquina";
            this.Load += new System.EventHandler(this.FMaquina_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.panel1Agregar.ResumeLayout(false);
            this.panel1Agregar.PerformLayout();
            this.panel2Modificar.ResumeLayout(false);
            this.panel2Modificar.PerformLayout();
            this.panel3Eliminar.ResumeLayout(false);
            this.panel3Eliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage panel1Agregar;
        private MetroFramework.Controls.MetroTile tab1btAgregar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox tab1tbFabricante;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox tab1tbID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage panel2Modificar;
        private MetroFramework.Controls.MetroTile tab2btModificar;
        private MetroFramework.Controls.MetroTabPage panel3Eliminar;
        private MetroFramework.Controls.MetroTile tab3btEliminar;
        private System.Windows.Forms.TextBox tab3tbID;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tab1tbModelo;
        private System.Windows.Forms.TextBox tab1tbCPU;
        private System.Windows.Forms.TextBox tab1tbGPU;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox tab2tbModelo;
        private System.Windows.Forms.TextBox tab2tbCPU;
        private System.Windows.Forms.TextBox tab2tbGPU;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.TextBox tab2tbFabricante;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.TextBox tab2tbID;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroGrid Grid;
        private System.Windows.Forms.ComboBox tab1cbRAM;
        private System.Windows.Forms.ComboBox tab1cbHDD;
        private System.Windows.Forms.ComboBox tab2cbHDD;
        private System.Windows.Forms.ComboBox tab2cbRAM;
    }
}