namespace pjt_interdisciplinar01
{
    partial class frm_Aluguel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid_06 = new System.Windows.Forms.DataGridView();
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
            this.gcbbox_nome = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gcbbox_carros = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gtxt_inicio = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_fim = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbtn_inserir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gbtn_devolucao = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_06)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // Grid_06
            // 
            this.Grid_06.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid_06.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_06.Location = new System.Drawing.Point(12, 185);
            this.Grid_06.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid_06.Name = "Grid_06";
            this.Grid_06.RowTemplate.Height = 28;
            this.Grid_06.Size = new System.Drawing.Size(1072, 429);
            this.Grid_06.TabIndex = 12;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1096, 28);
            this.menuStrip1.TabIndex = 38;
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
            // gcbbox_nome
            // 
            this.gcbbox_nome.BackColor = System.Drawing.Color.Transparent;
            this.gcbbox_nome.BorderRadius = 12;
            this.gcbbox_nome.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbbox_nome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbbox_nome.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_nome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbbox_nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcbbox_nome.ItemHeight = 30;
            this.gcbbox_nome.Location = new System.Drawing.Point(218, 64);
            this.gcbbox_nome.Name = "gcbbox_nome";
            this.gcbbox_nome.Size = new System.Drawing.Size(140, 36);
            this.gcbbox_nome.TabIndex = 39;
            // 
            // gcbbox_carros
            // 
            this.gcbbox_carros.BackColor = System.Drawing.Color.Transparent;
            this.gcbbox_carros.BorderRadius = 12;
            this.gcbbox_carros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbbox_carros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbbox_carros.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_carros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_carros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbbox_carros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcbbox_carros.ItemHeight = 30;
            this.gcbbox_carros.Location = new System.Drawing.Point(444, 64);
            this.gcbbox_carros.Name = "gcbbox_carros";
            this.gcbbox_carros.Size = new System.Drawing.Size(140, 36);
            this.gcbbox_carros.TabIndex = 40;
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
            this.gtxt_inicio.Location = new System.Drawing.Point(602, 64);
            this.gtxt_inicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_inicio.Name = "gtxt_inicio";
            this.gtxt_inicio.PasswordChar = '\0';
            this.gtxt_inicio.PlaceholderText = "Início";
            this.gtxt_inicio.SelectedText = "";
            this.gtxt_inicio.Size = new System.Drawing.Size(140, 36);
            this.gtxt_inicio.TabIndex = 41;
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
            this.gtxt_fim.Location = new System.Drawing.Point(777, 64);
            this.gtxt_fim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_fim.Name = "gtxt_fim";
            this.gtxt_fim.PasswordChar = '\0';
            this.gtxt_fim.PlaceholderText = "Fim";
            this.gtxt_fim.SelectedText = "";
            this.gtxt_fim.Size = new System.Drawing.Size(140, 36);
            this.gtxt_fim.TabIndex = 42;
            // 
            // gbtn_inserir
            // 
            this.gbtn_inserir.BorderRadius = 12;
            this.gbtn_inserir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_inserir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_inserir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_inserir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_inserir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_inserir.FillColor = System.Drawing.Color.DarkViolet;
            this.gbtn_inserir.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.gbtn_inserir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_inserir.ForeColor = System.Drawing.Color.White;
            this.gbtn_inserir.Location = new System.Drawing.Point(362, 113);
            this.gbtn_inserir.Name = "gbtn_inserir";
            this.gbtn_inserir.Size = new System.Drawing.Size(180, 45);
            this.gbtn_inserir.TabIndex = 43;
            this.gbtn_inserir.Text = "Inserir";
            this.gbtn_inserir.Click += new System.EventHandler(this.gbtn_inserir_Click);
            // 
            // gbtn_devolucao
            // 
            this.gbtn_devolucao.BorderRadius = 12;
            this.gbtn_devolucao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_devolucao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_devolucao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_devolucao.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_devolucao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_devolucao.FillColor = System.Drawing.Color.DarkViolet;
            this.gbtn_devolucao.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.gbtn_devolucao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_devolucao.ForeColor = System.Drawing.Color.White;
            this.gbtn_devolucao.Location = new System.Drawing.Point(562, 113);
            this.gbtn_devolucao.Name = "gbtn_devolucao";
            this.gbtn_devolucao.Size = new System.Drawing.Size(180, 45);
            this.gbtn_devolucao.TabIndex = 44;
            this.gbtn_devolucao.Text = "Devolução";
            this.gbtn_devolucao.Click += new System.EventHandler(this.gbtn_devolucao_Click);
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
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(-94, 113);
            this.guna2GradientCircleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(349, 349);
            this.guna2GradientCircleButton2.TabIndex = 55;
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
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(923, 47);
            this.guna2GradientCircleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(349, 349);
            this.guna2GradientCircleButton1.TabIndex = 56;
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
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(777, 446);
            this.guna2GradientCircleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(349, 349);
            this.guna2GradientCircleButton3.TabIndex = 57;
            // 
            // frm_Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 625);
            this.Controls.Add(this.gbtn_devolucao);
            this.Controls.Add(this.gbtn_inserir);
            this.Controls.Add(this.gtxt_fim);
            this.Controls.Add(this.gtxt_inicio);
            this.Controls.Add(this.gcbbox_carros);
            this.Controls.Add(this.gcbbox_nome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Grid_06);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Aluguel";
            this.Text = "frm_Aluguel";
            this.Load += new System.EventHandler(this.frm_Aluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_06)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Grid_06;
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
        private Guna.UI2.WinForms.Guna2ComboBox gcbbox_nome;
        private Guna.UI2.WinForms.Guna2ComboBox gcbbox_carros;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_inicio;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_fim;
        private Guna.UI2.WinForms.Guna2GradientButton gbtn_inserir;
        private Guna.UI2.WinForms.Guna2GradientButton gbtn_devolucao;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
    }
}