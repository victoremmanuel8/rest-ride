namespace pjt_interdisciplinar01
{
    partial class frm_Modelo
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
            this.Grid_03 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gbtn_inserir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gcbbox_Fabricantes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gtxt_Modelos = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientCircleButton1 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton2 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.guna2GradientCircleButton3 = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_03)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_03
            // 
            this.Grid_03.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid_03.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_03.Location = new System.Drawing.Point(13, 217);
            this.Grid_03.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid_03.Name = "Grid_03";
            this.Grid_03.Size = new System.Drawing.Size(1041, 382);
            this.Grid_03.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fabricantes";
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
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
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
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
            this.gbtn_inserir.Location = new System.Drawing.Point(427, 152);
            this.gbtn_inserir.Name = "gbtn_inserir";
            this.gbtn_inserir.Size = new System.Drawing.Size(168, 47);
            this.gbtn_inserir.TabIndex = 39;
            this.gbtn_inserir.Text = "Inserir";
            this.gbtn_inserir.Click += new System.EventHandler(this.gbtn_inserir_Click);
            // 
            // gcbbox_Fabricantes
            // 
            this.gcbbox_Fabricantes.BackColor = System.Drawing.Color.Transparent;
            this.gcbbox_Fabricantes.BorderRadius = 12;
            this.gcbbox_Fabricantes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbbox_Fabricantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbbox_Fabricantes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_Fabricantes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcbbox_Fabricantes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbbox_Fabricantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcbbox_Fabricantes.ItemHeight = 30;
            this.gcbbox_Fabricantes.Items.AddRange(new object[] {
            "Fiat",
            "Audi",
            "Honda",
            "Volkswagen"});
            this.gcbbox_Fabricantes.Location = new System.Drawing.Point(350, 95);
            this.gcbbox_Fabricantes.Name = "gcbbox_Fabricantes";
            this.gcbbox_Fabricantes.Size = new System.Drawing.Size(140, 36);
            this.gcbbox_Fabricantes.TabIndex = 40;
            // 
            // gtxt_Modelos
            // 
            this.gtxt_Modelos.BorderRadius = 12;
            this.gtxt_Modelos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_Modelos.DefaultText = "";
            this.gtxt_Modelos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_Modelos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_Modelos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Modelos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_Modelos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_Modelos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gtxt_Modelos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_Modelos.Location = new System.Drawing.Point(520, 95);
            this.gtxt_Modelos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gtxt_Modelos.Name = "gtxt_Modelos";
            this.gtxt_Modelos.PasswordChar = '\0';
            this.gtxt_Modelos.PlaceholderText = "Modelos";
            this.gtxt_Modelos.SelectedText = "";
            this.gtxt_Modelos.Size = new System.Drawing.Size(140, 36);
            this.gtxt_Modelos.TabIndex = 41;
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
            this.guna2GradientCircleButton1.Location = new System.Drawing.Point(-156, 169);
            this.guna2GradientCircleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
            this.guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton1.Size = new System.Drawing.Size(503, 497);
            this.guna2GradientCircleButton1.TabIndex = 42;
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
            this.guna2GradientCircleButton2.Location = new System.Drawing.Point(806, -30);
            this.guna2GradientCircleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
            this.guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton2.Size = new System.Drawing.Size(503, 497);
            this.guna2GradientCircleButton2.TabIndex = 43;
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
            this.guna2GradientCircleButton3.Location = new System.Drawing.Point(651, 169);
            this.guna2GradientCircleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
            this.guna2GradientCircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2GradientCircleButton3.Size = new System.Drawing.Size(103, 103);
            this.guna2GradientCircleButton3.TabIndex = 44;
            // 
            // frm_Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 612);
            this.Controls.Add(this.gtxt_Modelos);
            this.Controls.Add(this.gcbbox_Fabricantes);
            this.Controls.Add(this.gbtn_inserir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grid_03);
            this.Controls.Add(this.guna2GradientCircleButton1);
            this.Controls.Add(this.guna2GradientCircleButton2);
            this.Controls.Add(this.guna2GradientCircleButton3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Modelo";
            this.Text = "frm_Modelo";
            this.Load += new System.EventHandler(this.frm_Modelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_03)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid_03;
        private System.Windows.Forms.Label label2;
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
        private Guna.UI2.WinForms.Guna2GradientButton gbtn_inserir;
        private Guna.UI2.WinForms.Guna2ComboBox gcbbox_Fabricantes;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_Modelos;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;
    }
}