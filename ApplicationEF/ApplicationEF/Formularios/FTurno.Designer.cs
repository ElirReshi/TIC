namespace ApplicationEF.Formularios
{
    partial class FTurno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Grid = new MetroFramework.Controls.MetroGrid();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.panel1Agregar = new MetroFramework.Controls.MetroTabPage();
            this.tab1btAgregar = new MetroFramework.Controls.MetroTile();
            this.tab1mtbHoraS = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tab1mtbHoraE = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tab1tbTurno = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tab1tbCod = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2Modificar = new MetroFramework.Controls.MetroTabPage();
            this.tab2btModificar = new MetroFramework.Controls.MetroTile();
            this.tab2mtbHoraS = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tab2mtbHoraE = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tab2tbTurno = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tab2tbCod = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel3Eliminar = new MetroFramework.Controls.MetroTabPage();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tab3tbCod = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.TabIndex = 0;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(341, 242);
            this.Grid.TabIndex = 0;
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
            this.TabControl.SelectedIndex = 2;
            this.TabControl.Size = new System.Drawing.Size(227, 499);
            this.TabControl.TabIndex = 1;
            this.TabControl.UseSelectable = true;
            // 
            // panel1Agregar
            // 
            this.panel1Agregar.Controls.Add(this.tab1btAgregar);
            this.panel1Agregar.Controls.Add(this.tab1mtbHoraS);
            this.panel1Agregar.Controls.Add(this.metroLabel4);
            this.panel1Agregar.Controls.Add(this.tab1mtbHoraE);
            this.panel1Agregar.Controls.Add(this.metroLabel3);
            this.panel1Agregar.Controls.Add(this.tab1tbTurno);
            this.panel1Agregar.Controls.Add(this.metroLabel2);
            this.panel1Agregar.Controls.Add(this.tab1tbCod);
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
            // tab1btAgregar
            // 
            this.tab1btAgregar.ActiveControl = null;
            this.tab1btAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1btAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1btAgregar.Location = new System.Drawing.Point(6, 200);
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
            // tab1mtbHoraS
            // 
            this.tab1mtbHoraS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1mtbHoraS.Location = new System.Drawing.Point(6, 175);
            this.tab1mtbHoraS.Mask = "00:00";
            this.tab1mtbHoraS.Name = "tab1mtbHoraS";
            this.tab1mtbHoraS.Size = new System.Drawing.Size(210, 20);
            this.tab1mtbHoraS.TabIndex = 9;
            this.tab1mtbHoraS.ValidatingType = typeof(System.DateTime);
            this.tab1mtbHoraS.Click += new System.EventHandler(this.tab1mtbHoraS_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(96, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Hora de Salida";
            // 
            // tab1mtbHoraE
            // 
            this.tab1mtbHoraE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1mtbHoraE.Location = new System.Drawing.Point(6, 126);
            this.tab1mtbHoraE.Mask = "00:00";
            this.tab1mtbHoraE.Name = "tab1mtbHoraE";
            this.tab1mtbHoraE.Size = new System.Drawing.Size(210, 20);
            this.tab1mtbHoraE.TabIndex = 7;
            this.tab1mtbHoraE.ValidatingType = typeof(System.DateTime);
            this.tab1mtbHoraE.Click += new System.EventHandler(this.tab1mtbHoraE_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Hora de Entrada";
            // 
            // tab1tbTurno
            // 
            this.tab1tbTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1tbTurno.Location = new System.Drawing.Point(6, 77);
            this.tab1tbTurno.Name = "tab1tbTurno";
            this.tab1tbTurno.Size = new System.Drawing.Size(210, 20);
            this.tab1tbTurno.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Turno";
            // 
            // tab1tbCod
            // 
            this.tab1tbCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab1tbCod.Location = new System.Drawing.Point(6, 28);
            this.tab1tbCod.Name = "tab1tbCod";
            this.tab1tbCod.Size = new System.Drawing.Size(210, 20);
            this.tab1tbCod.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Código";
            // 
            // panel2Modificar
            // 
            this.panel2Modificar.Controls.Add(this.tab2btModificar);
            this.panel2Modificar.Controls.Add(this.tab2mtbHoraS);
            this.panel2Modificar.Controls.Add(this.metroLabel8);
            this.panel2Modificar.Controls.Add(this.tab2mtbHoraE);
            this.panel2Modificar.Controls.Add(this.metroLabel7);
            this.panel2Modificar.Controls.Add(this.tab2tbTurno);
            this.panel2Modificar.Controls.Add(this.metroLabel6);
            this.panel2Modificar.Controls.Add(this.tab2tbCod);
            this.panel2Modificar.Controls.Add(this.metroLabel5);
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
            // tab2btModificar
            // 
            this.tab2btModificar.ActiveControl = null;
            this.tab2btModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab2btModificar.Location = new System.Drawing.Point(6, 200);
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
            // tab2mtbHoraS
            // 
            this.tab2mtbHoraS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2mtbHoraS.Location = new System.Drawing.Point(6, 175);
            this.tab2mtbHoraS.Mask = "00:00";
            this.tab2mtbHoraS.Name = "tab2mtbHoraS";
            this.tab2mtbHoraS.Size = new System.Drawing.Size(210, 20);
            this.tab2mtbHoraS.TabIndex = 9;
            this.tab2mtbHoraS.ValidatingType = typeof(System.DateTime);
            this.tab2mtbHoraS.Click += new System.EventHandler(this.tab2mtbHoraS_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 151);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(96, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Hora de Salida";
            // 
            // tab2mtbHoraE
            // 
            this.tab2mtbHoraE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2mtbHoraE.Location = new System.Drawing.Point(6, 126);
            this.tab2mtbHoraE.Mask = "00:00";
            this.tab2mtbHoraE.Name = "tab2mtbHoraE";
            this.tab2mtbHoraE.Size = new System.Drawing.Size(210, 20);
            this.tab2mtbHoraE.TabIndex = 7;
            this.tab2mtbHoraE.ValidatingType = typeof(System.DateTime);
            this.tab2mtbHoraE.Click += new System.EventHandler(this.tab2mtbHoraE_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 102);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(106, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Hora de Entrada";
            // 
            // tab2tbTurno
            // 
            this.tab2tbTurno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2tbTurno.Location = new System.Drawing.Point(6, 77);
            this.tab2tbTurno.Name = "tab2tbTurno";
            this.tab2tbTurno.Size = new System.Drawing.Size(210, 20);
            this.tab2tbTurno.TabIndex = 5;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 53);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Turno";
            // 
            // tab2tbCod
            // 
            this.tab2tbCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab2tbCod.Location = new System.Drawing.Point(6, 28);
            this.tab2tbCod.Name = "tab2tbCod";
            this.tab2tbCod.Size = new System.Drawing.Size(210, 20);
            this.tab2tbCod.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 4);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Código";
            // 
            // panel3Eliminar
            // 
            this.panel3Eliminar.Controls.Add(this.metroTile1);
            this.panel3Eliminar.Controls.Add(this.tab3tbCod);
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(9, 52);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(210, 30);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Eliminar";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tab3tbCod
            // 
            this.tab3tbCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab3tbCod.Location = new System.Drawing.Point(6, 26);
            this.tab3tbCod.Name = "tab3tbCod";
            this.tab3tbCod.Size = new System.Drawing.Size(210, 20);
            this.tab3tbCod.TabIndex = 12;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(6, 4);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Código";
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
            this.label1.Text = "Turno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FTurno";
            this.Text = "FTurno";
            this.Load += new System.EventHandler(this.FTurno_Load);
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
        private MetroFramework.Controls.MetroGrid Grid;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage panel1Agregar;
        private MetroFramework.Controls.MetroTabPage panel2Modificar;
        private MetroFramework.Controls.MetroTabPage panel3Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tab1mtbHoraS;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.MaskedTextBox tab1mtbHoraE;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox tab1tbTurno;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox tab1tbCod;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tab1btAgregar;
        private MetroFramework.Controls.MetroTile tab2btModificar;
        private System.Windows.Forms.MaskedTextBox tab2mtbHoraS;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.MaskedTextBox tab2mtbHoraE;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox tab2tbTurno;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox tab2tbCod;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.TextBox tab3tbCod;
    }
}