namespace pjt_interdisciplinar01
{
    partial class frm_Devolucao
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
            this.Grid_07 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeFederativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gtxt_cliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_modelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_inicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_fim = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_custo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton4 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_07)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_07
            // 
            this.Grid_07.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid_07.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_07.Location = new System.Drawing.Point(12, 186);
            this.Grid_07.Name = "Grid_07";
            this.Grid_07.RowTemplate.Height = 28;
            this.Grid_07.Size = new System.Drawing.Size(867, 423);
            this.Grid_07.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosToolStripMenuItem,
            this.fabricanteToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.unidadeFederativaToolStripMenuItem});
            this.carroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.carroToolStripMenuItem.Text = "Carro";
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.carrosToolStripMenuItem.Text = "Carros";
            this.carrosToolStripMenuItem.Click += new System.EventHandler(this.carrosToolStripMenuItem_Click);
            // 
            // fabricanteToolStripMenuItem
            // 
            this.fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
            this.fabricanteToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.fabricanteToolStripMenuItem.Text = "Fabricante";
            this.fabricanteToolStripMenuItem.Click += new System.EventHandler(this.fabricanteToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.modeloToolStripMenuItem.Text = "Modelo";
            this.modeloToolStripMenuItem.Click += new System.EventHandler(this.modeloToolStripMenuItem_Click);
            // 
            // unidadeFederativaToolStripMenuItem
            // 
            this.unidadeFederativaToolStripMenuItem.Name = "unidadeFederativaToolStripMenuItem";
            this.unidadeFederativaToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.unidadeFederativaToolStripMenuItem.Text = "Unidade Federativa";
            this.unidadeFederativaToolStripMenuItem.Click += new System.EventHandler(this.unidadeFederativaToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.aluguelToolStripMenuItem,
            this.devoluçãoToolStripMenuItem});
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // aluguelToolStripMenuItem
            // 
            this.aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            this.aluguelToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.aluguelToolStripMenuItem.Text = "Aluguel";
            this.aluguelToolStripMenuItem.Click += new System.EventHandler(this.aluguelToolStripMenuItem_Click);
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            this.devoluçãoToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoToolStripMenuItem_Click);
            // 
            // gtxt_cliente
            // 
            this.gtxt_cliente.BorderRadius = 12;
            this.gtxt_cliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_cliente.DefaultText = "";
            this.gtxt_cliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_cliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_cliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_cliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_cliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_cliente.Location = new System.Drawing.Point(186, 58);
            this.gtxt_cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_cliente.Name = "gtxt_cliente";
            this.gtxt_cliente.PasswordChar = '\0';
            this.gtxt_cliente.PlaceholderText = "Cliente";
            this.gtxt_cliente.SelectedText = "";
            this.gtxt_cliente.Size = new System.Drawing.Size(168, 36);
            this.gtxt_cliente.TabIndex = 41;
            // 
            // gtxt_modelo
            // 
            this.gtxt_modelo.BorderRadius = 12;
            this.gtxt_modelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_modelo.DefaultText = "";
            this.gtxt_modelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_modelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_modelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_modelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_modelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_modelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_modelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_modelo.Location = new System.Drawing.Point(186, 115);
            this.gtxt_modelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_modelo.Name = "gtxt_modelo";
            this.gtxt_modelo.PasswordChar = '\0';
            this.gtxt_modelo.PlaceholderText = "Modelo";
            this.gtxt_modelo.SelectedText = "";
            this.gtxt_modelo.Size = new System.Drawing.Size(168, 36);
            this.gtxt_modelo.TabIndex = 42;
            // 
            // gtxt_inicio
            // 
            this.gtxt_inicio.BorderRadius = 12;
            this.gtxt_inicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_inicio.DefaultText = "";
            this.gtxt_inicio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_inicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_inicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_inicio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_inicio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_inicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_inicio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_inicio.Location = new System.Drawing.Point(381, 58);
            this.gtxt_inicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_inicio.Name = "gtxt_inicio";
            this.gtxt_inicio.PasswordChar = '\0';
            this.gtxt_inicio.PlaceholderText = "Data início";
            this.gtxt_inicio.SelectedText = "";
            this.gtxt_inicio.Size = new System.Drawing.Size(168, 36);
            this.gtxt_inicio.TabIndex = 43;
            // 
            // gtxt_fim
            // 
            this.gtxt_fim.BorderRadius = 12;
            this.gtxt_fim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_fim.DefaultText = "";
            this.gtxt_fim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_fim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_fim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_fim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_fim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_fim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_fim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_fim.Location = new System.Drawing.Point(381, 112);
            this.gtxt_fim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_fim.Name = "gtxt_fim";
            this.gtxt_fim.PasswordChar = '\0';
            this.gtxt_fim.PlaceholderText = "Data Fim";
            this.gtxt_fim.SelectedText = "";
            this.gtxt_fim.Size = new System.Drawing.Size(168, 36);
            this.gtxt_fim.TabIndex = 44;
            // 
            // gtxt_custo
            // 
            this.gtxt_custo.BorderRadius = 12;
            this.gtxt_custo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_custo.DefaultText = "";
            this.gtxt_custo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_custo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_custo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_custo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_custo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_custo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_custo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_custo.Location = new System.Drawing.Point(575, 82);
            this.gtxt_custo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_custo.Name = "gtxt_custo";
            this.gtxt_custo.PasswordChar = '\0';
            this.gtxt_custo.PlaceholderText = "Custo";
            this.gtxt_custo.SelectedText = "";
            this.gtxt_custo.Size = new System.Drawing.Size(168, 36);
            this.gtxt_custo.TabIndex = 45;
            // 
            // guna2GradientCircleButton2
            // 
            this.guna2GradientCircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton2.FillColor = System.Drawing.Color.DarkViolet;
            this.guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.guna2GradientCircleButton2.FocusedColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(-323, 49);
            this.guna2GradientCircleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(503, 497);
            this.guna2GradientCircleButton2.TabIndex = 46;
            // 
            // guna2GradientCircleButton1
            // 
            this.guna2GradientCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton1.FillColor = System.Drawing.Color.DarkViolet;
            this.guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.guna2GradientCircleButton1.FocusedColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(599, 205);
            this.guna2GradientCircleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(503, 497);
            this.guna2GradientCircleButton1.TabIndex = 47;
            // 
            // guna2GradientCircleButton3
            // 
            this.guna2GradientCircleButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton3.FillColor = System.Drawing.Color.DarkViolet;
            this.guna2GradientCircleButton3.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.guna2GradientCircleButton3.FocusedColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(619, -275);
            this.guna2GradientCircleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(349, 349);
            this.guna2GradientCircleButton3.TabIndex = 48;
            // 
            // guna2GradientCircleButton4
            // 
            this.guna2GradientCircleButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientCircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientCircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientCircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientCircleButton4.FillColor = System.Drawing.Color.DarkViolet;
            this.guna2GradientCircleButton4.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.guna2GradientCircleButton4.FocusedColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientCircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCircleButton4.Location = new System.Drawing.Point(194, 517);
            this.guna2GradientCircleButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton4.Name = "guna2GradientCircleButton4";
            this.guna2GradientCircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton4.Size = new System.Drawing.Size(160, 160);
            this.guna2GradientCircleButton4.TabIndex = 49;
            // 
            // frm_Devolucao
            // 
            this.ClientSize = new System.Drawing.Size(891, 632);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Controls.Add(this.gtxt_custo);
            this.Controls.Add(this.gtxt_fim);
            this.Controls.Add(this.gtxt_inicio);
            this.Controls.Add(this.gtxt_modelo);
            this.Controls.Add(this.gtxt_cliente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Grid_07);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2GradientCircleButton4);
            this.Name = "frm_Devolucao";
            this.Load += new System.EventHandler(this.frm_Devolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_07)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid_07;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeFederativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_cliente;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_modelo;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_inicio;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_fim;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_custo;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton4;
    }
}