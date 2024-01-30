namespace pjt_interdisciplinar01
{
    partial class frm_Cliente
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Grid_05 = new System.Windows.Forms.DataGridView();
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
            this.gcbbox_uf = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gcbbox_cidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbtn_inserir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gtxt_nome = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_cpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_rg = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_habilitacao = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_endereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.gtxt_numero = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_05)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(692, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "UF:";
            // 
            // Grid_05
            // 
            this.Grid_05.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid_05.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_05.Location = new System.Drawing.Point(15, 241);
            this.Grid_05.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid_05.Name = "Grid_05";
            this.Grid_05.RowTemplate.Height = 28;
            this.Grid_05.Size = new System.Drawing.Size(1072, 382);
            this.Grid_05.TabIndex = 16;
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
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 41;
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
            // gcbbox_uf
            // 
            this.gcbbox_uf.BackColor = System.Drawing.Color.Transparent;
            this.gcbbox_uf.BorderRadius = 12;
            this.gcbbox_uf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbbox_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbbox_uf.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_uf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_uf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbbox_uf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcbbox_uf.ItemHeight = 30;
            this.gcbbox_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.gcbbox_uf.Location = new System.Drawing.Point(787, 109);
            this.gcbbox_uf.Name = "gcbbox_uf";
            this.gcbbox_uf.Size = new System.Drawing.Size(140, 36);
            this.gcbbox_uf.TabIndex = 42;
            this.gcbbox_uf.SelectedIndexChanged += new System.EventHandler(this.gcbbox_uf_SelectedIndexChanged);
            // 
            // gcbbox_cidade
            // 
            this.gcbbox_cidade.BackColor = System.Drawing.Color.Transparent;
            this.gcbbox_cidade.BorderRadius = 12;
            this.gcbbox_cidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbbox_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbbox_cidade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_cidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_cidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbbox_cidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcbbox_cidade.ItemHeight = 30;
            this.gcbbox_cidade.Location = new System.Drawing.Point(754, 67);
            this.gcbbox_cidade.Name = "gcbbox_cidade";
            this.gcbbox_cidade.Size = new System.Drawing.Size(140, 36);
            this.gcbbox_cidade.TabIndex = 43;
            // 
            // gbtn_inserir
            // 
            this.gbtn_inserir.BorderRadius = 12;
            this.gbtn_inserir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_inserir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_inserir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_inserir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_inserir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_inserir.Enabled = false;
            this.gbtn_inserir.FillColor = System.Drawing.Color.DarkViolet;
            this.gbtn_inserir.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.gbtn_inserir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_inserir.ForeColor = System.Drawing.Color.White;
            this.gbtn_inserir.Location = new System.Drawing.Point(486, 173);
            this.gbtn_inserir.Name = "gbtn_inserir";
            this.gbtn_inserir.Size = new System.Drawing.Size(180, 45);
            this.gbtn_inserir.TabIndex = 44;
            this.gbtn_inserir.Text = "Inserir";
            this.gbtn_inserir.Click += new System.EventHandler(this.gbtn_inserir_Click);
            // 
            // gtxt_nome
            // 
            this.gtxt_nome.BorderRadius = 12;
            this.gtxt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_nome.DefaultText = "";
            this.gtxt_nome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_nome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_nome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_nome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_nome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_nome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_nome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_nome.Location = new System.Drawing.Point(180, 67);
            this.gtxt_nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_nome.Name = "gtxt_nome";
            this.gtxt_nome.PasswordChar = '\0';
            this.gtxt_nome.PlaceholderText = "Nome";
            this.gtxt_nome.SelectedText = "";
            this.gtxt_nome.Size = new System.Drawing.Size(229, 36);
            this.gtxt_nome.TabIndex = 45;
            // 
            // gtxt_cpf
            // 
            this.gtxt_cpf.BorderRadius = 12;
            this.gtxt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_cpf.DefaultText = "";
            this.gtxt_cpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_cpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_cpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_cpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_cpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_cpf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_cpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_cpf.Location = new System.Drawing.Point(180, 111);
            this.gtxt_cpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_cpf.Name = "gtxt_cpf";
            this.gtxt_cpf.PasswordChar = '\0';
            this.gtxt_cpf.PlaceholderText = "CPF";
            this.gtxt_cpf.SelectedText = "";
            this.gtxt_cpf.Size = new System.Drawing.Size(129, 36);
            this.gtxt_cpf.TabIndex = 46;
            // 
            // gtxt_rg
            // 
            this.gtxt_rg.BorderRadius = 12;
            this.gtxt_rg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_rg.DefaultText = "";
            this.gtxt_rg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_rg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_rg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_rg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_rg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_rg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_rg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_rg.Location = new System.Drawing.Point(315, 111);
            this.gtxt_rg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_rg.Name = "gtxt_rg";
            this.gtxt_rg.PasswordChar = '\0';
            this.gtxt_rg.PlaceholderText = "RG";
            this.gtxt_rg.SelectedText = "";
            this.gtxt_rg.Size = new System.Drawing.Size(129, 36);
            this.gtxt_rg.TabIndex = 47;
            // 
            // gtxt_habilitacao
            // 
            this.gtxt_habilitacao.BorderRadius = 12;
            this.gtxt_habilitacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_habilitacao.DefaultText = "";
            this.gtxt_habilitacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_habilitacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_habilitacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_habilitacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_habilitacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_habilitacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_habilitacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_habilitacao.Location = new System.Drawing.Point(437, 67);
            this.gtxt_habilitacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_habilitacao.Name = "gtxt_habilitacao";
            this.gtxt_habilitacao.PasswordChar = '\0';
            this.gtxt_habilitacao.PlaceholderText = "NR Habilitação";
            this.gtxt_habilitacao.SelectedText = "";
            this.gtxt_habilitacao.Size = new System.Drawing.Size(229, 36);
            this.gtxt_habilitacao.TabIndex = 48;
            // 
            // gtxt_endereco
            // 
            this.gtxt_endereco.BorderRadius = 12;
            this.gtxt_endereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_endereco.DefaultText = "";
            this.gtxt_endereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_endereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_endereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_endereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_endereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_endereco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_endereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_endereco.Location = new System.Drawing.Point(465, 111);
            this.gtxt_endereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_endereco.Name = "gtxt_endereco";
            this.gtxt_endereco.PasswordChar = '\0';
            this.gtxt_endereco.PlaceholderText = "Endereço";
            this.gtxt_endereco.SelectedText = "";
            this.gtxt_endereco.Size = new System.Drawing.Size(129, 36);
            this.gtxt_endereco.TabIndex = 49;
            // 
            // gtxt_numero
            // 
            this.gtxt_numero.BorderRadius = 12;
            this.gtxt_numero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_numero.DefaultText = "";
            this.gtxt_numero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_numero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_numero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_numero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_numero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_numero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_numero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_numero.Location = new System.Drawing.Point(611, 111);
            this.gtxt_numero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_numero.Name = "gtxt_numero";
            this.gtxt_numero.PasswordChar = '\0';
            this.gtxt_numero.PlaceholderText = "Nº";
            this.gtxt_numero.SelectedText = "";
            this.gtxt_numero.Size = new System.Drawing.Size(129, 36);
            this.gtxt_numero.TabIndex = 50;
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
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(-126, 155);
            this.guna2GradientCircleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(349, 349);
            this.guna2GradientCircleButton3.TabIndex = 51;
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
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(945, -60);
            this.guna2GradientCircleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(349, 349);
            this.guna2GradientCircleButton1.TabIndex = 52;
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
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(721, 389);
            this.guna2GradientCircleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(429, 429);
            this.guna2GradientCircleButton2.TabIndex = 53;
            // 
            // frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 634);
            this.Controls.Add(this.gtxt_numero);
            this.Controls.Add(this.gtxt_endereco);
            this.Controls.Add(this.gtxt_habilitacao);
            this.Controls.Add(this.gtxt_rg);
            this.Controls.Add(this.gtxt_cpf);
            this.Controls.Add(this.gtxt_nome);
            this.Controls.Add(this.gbtn_inserir);
            this.Controls.Add(this.gcbbox_cidade);
            this.Controls.Add(this.gcbbox_uf);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Grid_05);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Cliente";
            this.Text = "frm_Cliente";
            this.Load += new System.EventHandler(this.frm_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_05)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Grid_05;
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
        private Guna.UI2.WinForms.Guna2ComboBox gcbbox_uf;
        private Guna.UI2.WinForms.Guna2ComboBox gcbbox_cidade;
        private Guna.UI2.WinForms.Guna2GradientButton gbtn_inserir;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_nome;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_cpf;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_rg;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_habilitacao;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_endereco;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_numero;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
    }
}