namespace LabTP2
{
    partial class fAlojamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlojamiento));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tBDIreccion = new System.Windows.Forms.TextBox();
            this.gbCasa = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.chBMascotas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chBWifi = new System.Windows.Forms.CheckBox();
            this.chBDesayuno = new System.Windows.Forms.CheckBox();
            this.chBPileta = new System.Windows.Forms.CheckBox();
            this.chBLimpieza = new System.Windows.Forms.CheckBox();
            this.chBCochera = new System.Windows.Forms.CheckBox();
            this.gbHotel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBNumHab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbAlojamientos = new System.Windows.Forms.ComboBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bModif = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.gbCasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.gbHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Habitacion",
            "Casa"});
            this.comboBox1.Location = new System.Drawing.Point(143, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tBDIreccion
            // 
            this.tBDIreccion.BackColor = System.Drawing.Color.LimeGreen;
            this.tBDIreccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBDIreccion.Location = new System.Drawing.Point(143, 122);
            this.tBDIreccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBDIreccion.Name = "tBDIreccion";
            this.tBDIreccion.Size = new System.Drawing.Size(140, 21);
            this.tBDIreccion.TabIndex = 2;
            // 
            // gbCasa
            // 
            this.gbCasa.Controls.Add(this.numericUpDown2);
            this.gbCasa.Controls.Add(this.chBMascotas);
            this.gbCasa.Controls.Add(this.label4);
            this.gbCasa.Controls.Add(this.chBWifi);
            this.gbCasa.Controls.Add(this.chBDesayuno);
            this.gbCasa.Controls.Add(this.chBPileta);
            this.gbCasa.Controls.Add(this.chBLimpieza);
            this.gbCasa.Controls.Add(this.chBCochera);
            this.gbCasa.Location = new System.Drawing.Point(37, 186);
            this.gbCasa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCasa.Name = "gbCasa";
            this.gbCasa.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCasa.Size = new System.Drawing.Size(251, 207);
            this.gbCasa.TabIndex = 3;
            this.gbCasa.TabStop = false;
            this.gbCasa.Text = "Casa";
            this.gbCasa.Enter += new System.EventHandler(this.gbCasa_Enter);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.LimeGreen;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Location = new System.Drawing.Point(130, 168);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 21);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chBMascotas
            // 
            this.chBMascotas.AutoSize = true;
            this.chBMascotas.Location = new System.Drawing.Point(25, 140);
            this.chBMascotas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chBMascotas.Name = "chBMascotas";
            this.chBMascotas.Size = new System.Drawing.Size(78, 17);
            this.chBMascotas.TabIndex = 7;
            this.chBMascotas.Text = "Mascotas";
            this.chBMascotas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dias Minimos";
            // 
            // chBWifi
            // 
            this.chBWifi.AutoSize = true;
            this.chBWifi.Location = new System.Drawing.Point(25, 71);
            this.chBWifi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chBWifi.Name = "chBWifi";
            this.chBWifi.Size = new System.Drawing.Size(47, 17);
            this.chBWifi.TabIndex = 7;
            this.chBWifi.Text = "Wifi";
            this.chBWifi.UseVisualStyleBackColor = true;
            // 
            // chBDesayuno
            // 
            this.chBDesayuno.AutoSize = true;
            this.chBDesayuno.Location = new System.Drawing.Point(25, 117);
            this.chBDesayuno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chBDesayuno.Name = "chBDesayuno";
            this.chBDesayuno.Size = new System.Drawing.Size(83, 17);
            this.chBDesayuno.TabIndex = 7;
            this.chBDesayuno.Text = "Desayuno";
            this.chBDesayuno.UseVisualStyleBackColor = true;
            // 
            // chBPileta
            // 
            this.chBPileta.AutoSize = true;
            this.chBPileta.Location = new System.Drawing.Point(25, 48);
            this.chBPileta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chBPileta.Name = "chBPileta";
            this.chBPileta.Size = new System.Drawing.Size(57, 17);
            this.chBPileta.TabIndex = 7;
            this.chBPileta.Text = "Pileta";
            this.chBPileta.UseVisualStyleBackColor = true;
            // 
            // chBLimpieza
            // 
            this.chBLimpieza.AutoSize = true;
            this.chBLimpieza.Location = new System.Drawing.Point(25, 94);
            this.chBLimpieza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chBLimpieza.Name = "chBLimpieza";
            this.chBLimpieza.Size = new System.Drawing.Size(110, 17);
            this.chBLimpieza.TabIndex = 7;
            this.chBLimpieza.Text = "Serv. Limpieza";
            this.chBLimpieza.UseVisualStyleBackColor = true;
            // 
            // chBCochera
            // 
            this.chBCochera.AutoSize = true;
            this.chBCochera.Location = new System.Drawing.Point(25, 25);
            this.chBCochera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chBCochera.Name = "chBCochera";
            this.chBCochera.Size = new System.Drawing.Size(74, 17);
            this.chBCochera.TabIndex = 7;
            this.chBCochera.Text = "Cochera";
            this.chBCochera.UseVisualStyleBackColor = true;
            // 
            // gbHotel
            // 
            this.gbHotel.BackColor = System.Drawing.Color.DarkGray;
            this.gbHotel.Controls.Add(this.label5);
            this.gbHotel.Controls.Add(this.comboBox2);
            this.gbHotel.Controls.Add(this.label6);
            this.gbHotel.Controls.Add(this.tBNumHab);
            this.gbHotel.Controls.Add(this.label7);
            this.gbHotel.Location = new System.Drawing.Point(40, 186);
            this.gbHotel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbHotel.Name = "gbHotel";
            this.gbHotel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbHotel.Size = new System.Drawing.Size(248, 100);
            this.gbHotel.TabIndex = 4;
            this.gbHotel.TabStop = false;
            this.gbHotel.Text = "Hotel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-34, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "⭐⭐",
            "⭐⭐⭐"});
            this.comboBox2.Location = new System.Drawing.Point(119, 29);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estrellas";
            // 
            // tBNumHab
            // 
            this.tBNumHab.BackColor = System.Drawing.Color.LimeGreen;
            this.tBNumHab.Location = new System.Drawing.Point(119, 65);
            this.tBNumHab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tBNumHab.Name = "tBNumHab";
            this.tBNumHab.Size = new System.Drawing.Size(112, 21);
            this.tBNumHab.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Num Habitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.LimeGreen;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(144, 86);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 21);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbAlojamientos
            // 
            this.cbAlojamientos.BackColor = System.Drawing.Color.LimeGreen;
            this.cbAlojamientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAlojamientos.FormattingEnabled = true;
            this.cbAlojamientos.Location = new System.Drawing.Point(143, 12);
            this.cbAlojamientos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAlojamientos.Name = "cbAlojamientos";
            this.cbAlojamientos.Size = new System.Drawing.Size(140, 21);
            this.cbAlojamientos.TabIndex = 7;
            this.cbAlojamientos.SelectedIndexChanged += new System.EventHandler(this.cbAlojamientos_SelectedIndexChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAgregar.Location = new System.Drawing.Point(305, 105);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(88, 23);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bModif
            // 
            this.bModif.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bModif.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bModif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bModif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bModif.Location = new System.Drawing.Point(305, 105);
            this.bModif.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bModif.Name = "bModif";
            this.bModif.Size = new System.Drawing.Size(88, 23);
            this.bModif.TabIndex = 8;
            this.bModif.Text = "MODIFICAR";
            this.bModif.UseVisualStyleBackColor = false;
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Red;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancel.Location = new System.Drawing.Point(305, 58);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(88, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "CANCELAR";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // bEliminar
            // 
            this.bEliminar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bEliminar.Location = new System.Drawing.Point(305, 10);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(88, 23);
            this.bEliminar.TabIndex = 8;
            this.bEliminar.Text = "Dar Baja";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // fAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModif);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.cbAlojamientos);
            this.Controls.Add(this.gbCasa);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbHotel);
            this.Controls.Add(this.tBDIreccion);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fAlojamiento";
            this.Text = "fAlojamiento";
            this.Load += new System.EventHandler(this.fAlojamiento_Load);
            this.gbCasa.ResumeLayout(false);
            this.gbCasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.gbHotel.ResumeLayout(false);
            this.gbHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox tBDIreccion;
        public System.Windows.Forms.GroupBox gbCasa;
        public System.Windows.Forms.GroupBox gbHotel;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
        public System.Windows.Forms.CheckBox chBMascotas;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox chBWifi;
        public System.Windows.Forms.CheckBox chBDesayuno;
        public System.Windows.Forms.CheckBox chBPileta;
        public System.Windows.Forms.CheckBox chBLimpieza;
        public System.Windows.Forms.CheckBox chBCochera;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ComboBox cbAlojamientos;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tBNumHab;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button bAgregar;
        public System.Windows.Forms.Button bModif;
        public System.Windows.Forms.Button bCancel;
        public System.Windows.Forms.Button bEliminar;
    }
}