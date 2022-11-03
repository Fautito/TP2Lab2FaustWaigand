namespace LabTP2
{
    partial class Fprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlojAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlojBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlojModi = new System.Windows.Forms.ToolStripMenuItem();
            this.cleintesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClienteVer = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservaAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservaBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservaModi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReservaConsu = new System.Windows.Forms.ToolStripMenuItem();
            this.cBalojamiento = new System.Windows.Forms.ComboBox();
            this.cBestrellas = new System.Windows.Forms.ComboBox();
            this.cBhabit = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cBcamas = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cleintesToolStripMenuItem,
            this.reservasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlojAlta,
            this.menuAlojBaja,
            this.menuAlojModi});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.menuToolStripMenuItem.Text = "Alojamientos";
            // 
            // menuAlojAlta
            // 
            this.menuAlojAlta.Name = "menuAlojAlta";
            this.menuAlojAlta.Size = new System.Drawing.Size(125, 22);
            this.menuAlojAlta.Text = "Alta";
            this.menuAlojAlta.Click += new System.EventHandler(this.menuAlojAlta_Click);
            // 
            // menuAlojBaja
            // 
            this.menuAlojBaja.Name = "menuAlojBaja";
            this.menuAlojBaja.Size = new System.Drawing.Size(125, 22);
            this.menuAlojBaja.Text = "Baja";
            this.menuAlojBaja.Click += new System.EventHandler(this.menuAlojBaja_Click);
            // 
            // menuAlojModi
            // 
            this.menuAlojModi.Name = "menuAlojModi";
            this.menuAlojModi.Size = new System.Drawing.Size(125, 22);
            this.menuAlojModi.Text = "Modificar";
            this.menuAlojModi.Click += new System.EventHandler(this.menuAlojModi_Click);
            // 
            // cleintesToolStripMenuItem
            // 
            this.cleintesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClienteRegistrar,
            this.menuClienteVer});
            this.cleintesToolStripMenuItem.Name = "cleintesToolStripMenuItem";
            this.cleintesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.cleintesToolStripMenuItem.Text = "Clientes";
            // 
            // menuClienteRegistrar
            // 
            this.menuClienteRegistrar.Name = "menuClienteRegistrar";
            this.menuClienteRegistrar.Size = new System.Drawing.Size(124, 22);
            this.menuClienteRegistrar.Text = "Registrar";
            this.menuClienteRegistrar.Click += new System.EventHandler(this.menuClienteRegistrar_Click);
            // 
            // menuClienteVer
            // 
            this.menuClienteVer.Name = "menuClienteVer";
            this.menuClienteVer.Size = new System.Drawing.Size(124, 22);
            this.menuClienteVer.Text = "Ver Todos";
            this.menuClienteVer.Click += new System.EventHandler(this.menuClienteVer_Click);
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReservaAlta,
            this.menuReservaBaja,
            this.menuReservaModi,
            this.menuReservaConsu});
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            // 
            // menuReservaAlta
            // 
            this.menuReservaAlta.Name = "menuReservaAlta";
            this.menuReservaAlta.Size = new System.Drawing.Size(125, 22);
            this.menuReservaAlta.Text = "Alta";
            // 
            // menuReservaBaja
            // 
            this.menuReservaBaja.Name = "menuReservaBaja";
            this.menuReservaBaja.Size = new System.Drawing.Size(125, 22);
            this.menuReservaBaja.Text = "Baja";
            // 
            // menuReservaModi
            // 
            this.menuReservaModi.Name = "menuReservaModi";
            this.menuReservaModi.Size = new System.Drawing.Size(125, 22);
            this.menuReservaModi.Text = "Modificar";
            // 
            // menuReservaConsu
            // 
            this.menuReservaConsu.Name = "menuReservaConsu";
            this.menuReservaConsu.Size = new System.Drawing.Size(125, 22);
            this.menuReservaConsu.Text = "Consultar";
            this.menuReservaConsu.Click += new System.EventHandler(this.menuReservaConsu_Click);
            // 
            // cBalojamiento
            // 
            this.cBalojamiento.BackColor = System.Drawing.Color.SteelBlue;
            this.cBalojamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBalojamiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBalojamiento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBalojamiento.FormattingEnabled = true;
            this.cBalojamiento.Items.AddRange(new object[] {
            "Todo",
            "Hotel",
            "Casa"});
            this.cBalojamiento.Location = new System.Drawing.Point(34, 58);
            this.cBalojamiento.Name = "cBalojamiento";
            this.cBalojamiento.Size = new System.Drawing.Size(121, 24);
            this.cBalojamiento.TabIndex = 1;
            this.cBalojamiento.SelectedIndexChanged += new System.EventHandler(this.cBalojamiento_SelectedIndexChanged);
            // 
            // cBestrellas
            // 
            this.cBestrellas.BackColor = System.Drawing.Color.SteelBlue;
            this.cBestrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBestrellas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBestrellas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBestrellas.FormattingEnabled = true;
            this.cBestrellas.Items.AddRange(new object[] {
            "Todos",
            "⭐⭐",
            "⭐⭐⭐"});
            this.cBestrellas.Location = new System.Drawing.Point(190, 57);
            this.cBestrellas.Name = "cBestrellas";
            this.cBestrellas.Size = new System.Drawing.Size(121, 24);
            this.cBestrellas.TabIndex = 2;
            this.cBestrellas.SelectedIndexChanged += new System.EventHandler(this.cBestrellas_SelectedIndexChanged);
            // 
            // cBhabit
            // 
            this.cBhabit.BackColor = System.Drawing.Color.SteelBlue;
            this.cBhabit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBhabit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBhabit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBhabit.FormattingEnabled = true;
            this.cBhabit.Items.AddRange(new object[] {
            "Todos",
            "Simple",
            "Doble",
            "Triple"});
            this.cBhabit.Location = new System.Drawing.Point(345, 56);
            this.cBhabit.Name = "cBhabit";
            this.cBhabit.Size = new System.Drawing.Size(121, 24);
            this.cBhabit.TabIndex = 3;
            this.cBhabit.SelectedIndexChanged += new System.EventHandler(this.cBhabit_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(34, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(560, 185);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 1F;
            this.Column1.HeaderText = "Imagen";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 10F;
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 350;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reservar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBcamas
            // 
            this.cBcamas.BackColor = System.Drawing.Color.SteelBlue;
            this.cBcamas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBcamas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBcamas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBcamas.FormattingEnabled = true;
            this.cBcamas.Items.AddRange(new object[] {
            "Todos",
            "1 cama",
            "2 camas",
            "3 camas",
            "4 camas",
            "5 camas"});
            this.cBcamas.Location = new System.Drawing.Point(190, 57);
            this.cBcamas.Name = "cBcamas";
            this.cBcamas.Size = new System.Drawing.Size(121, 24);
            this.cBcamas.TabIndex = 3;
            this.cBcamas.SelectedIndexChanged += new System.EventHandler(this.cBcamas_SelectedIndexChanged);
            // 
            // Fprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::LabTP2.Properties.Resources.polimorfism;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBcamas);
            this.Controls.Add(this.cBhabit);
            this.Controls.Add(this.cBestrellas);
            this.Controls.Add(this.cBalojamiento);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fprincipal_FormClosing);
            this.Load += new System.EventHandler(this.Fprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAlojAlta;
        private System.Windows.Forms.ToolStripMenuItem menuAlojBaja;
        private System.Windows.Forms.ToolStripMenuItem menuAlojModi;
        private System.Windows.Forms.ComboBox cBestrellas;
        private System.Windows.Forms.ComboBox cBhabit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBalojamiento;
        private System.Windows.Forms.ComboBox cBcamas;
        private System.Windows.Forms.ToolStripMenuItem cleintesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuClienteRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuClienteVer;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuReservaAlta;
        private System.Windows.Forms.ToolStripMenuItem menuReservaBaja;
        private System.Windows.Forms.ToolStripMenuItem menuReservaModi;
        private System.Windows.Forms.ToolStripMenuItem menuReservaConsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

