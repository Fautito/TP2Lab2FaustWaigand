﻿namespace LabTP2
{
    partial class FcalendarioYdatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FcalendarioYdatos));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.tBdireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBnum = new System.Windows.Forms.TextBox();
            this.tBcantPersonas = new System.Windows.Forms.TextBox();
            this.cBeshotel = new System.Windows.Forms.CheckBox();
            this.cBhabitacion = new System.Windows.Forms.ComboBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(-6, 30);
            this.monthCalendar1.MaxDate = new System.DateTime(2023, 1, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.InactiveCaption;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(100, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Direccion : ";
            // 
            // tBdireccion
            // 
            this.tBdireccion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tBdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBdireccion.Location = new System.Drawing.Point(205, 226);
            this.tBdireccion.Name = "tBdireccion";
            this.tBdireccion.Size = new System.Drawing.Size(196, 23);
            this.tBdireccion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(111, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(38, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de habitacion : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(8, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad de habitantes : ";
            // 
            // tBnum
            // 
            this.tBnum.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tBnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBnum.Location = new System.Drawing.Point(205, 260);
            this.tBnum.Name = "tBnum";
            this.tBnum.Size = new System.Drawing.Size(71, 23);
            this.tBnum.TabIndex = 6;
            // 
            // tBcantPersonas
            // 
            this.tBcantPersonas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tBcantPersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBcantPersonas.Location = new System.Drawing.Point(205, 315);
            this.tBcantPersonas.Name = "tBcantPersonas";
            this.tBcantPersonas.Size = new System.Drawing.Size(41, 23);
            this.tBcantPersonas.TabIndex = 7;
            // 
            // cBeshotel
            // 
            this.cBeshotel.AutoSize = true;
            this.cBeshotel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cBeshotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBeshotel.Location = new System.Drawing.Point(315, 263);
            this.cBeshotel.Name = "cBeshotel";
            this.cBeshotel.Size = new System.Drawing.Size(58, 20);
            this.cBeshotel.TabIndex = 8;
            this.cBeshotel.Text = "Hotel";
            this.cBeshotel.UseVisualStyleBackColor = false;
            // 
            // cBhabitacion
            // 
            this.cBhabitacion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cBhabitacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBhabitacion.FormattingEnabled = true;
            this.cBhabitacion.Items.AddRange(new object[] {
            "Simple",
            "Doble ",
            "Triple"});
            this.cBhabitacion.Location = new System.Drawing.Point(205, 288);
            this.cBhabitacion.Name = "cBhabitacion";
            this.cBhabitacion.Size = new System.Drawing.Size(121, 24);
            this.cBhabitacion.TabIndex = 9;
            // 
            // btnaceptar
            // 
            this.btnaceptar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaceptar.BackgroundImage = global::LabTP2.Properties.Resources.btnaceptar;
            this.btnaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaceptar.Location = new System.Drawing.Point(459, 359);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(104, 29);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaceptar.UseVisualStyleBackColor = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.Location = new System.Drawing.Point(111, 359);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(101, 29);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // FcalendarioYdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabTP2.Properties.Resources.ciudad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 427);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.cBhabitacion);
            this.Controls.Add(this.cBeshotel);
            this.Controls.Add(this.tBcantPersonas);
            this.Controls.Add(this.tBnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBdireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FcalendarioYdatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FcalendarioYdatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBdireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBnum;
        private System.Windows.Forms.TextBox tBcantPersonas;
        private System.Windows.Forms.CheckBox cBeshotel;
        private System.Windows.Forms.ComboBox cBhabitacion;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}