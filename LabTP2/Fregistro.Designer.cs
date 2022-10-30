namespace LabTP2
{
    partial class Fregistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fregistro));
            this.lBregistro = new System.Windows.Forms.ListBox();
            this.bBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBregistro
            // 
            this.lBregistro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lBregistro.FormattingEnabled = true;
            this.lBregistro.ItemHeight = 16;
            this.lBregistro.Location = new System.Drawing.Point(41, 28);
            this.lBregistro.Name = "lBregistro";
            this.lBregistro.Size = new System.Drawing.Size(287, 292);
            this.lBregistro.TabIndex = 0;
            // 
            // bBaja
            // 
            this.bBaja.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bBaja.Location = new System.Drawing.Point(187, 341);
            this.bBaja.Name = "bBaja";
            this.bBaja.Size = new System.Drawing.Size(141, 27);
            this.bBaja.TabIndex = 1;
            this.bBaja.Text = "Cancelar Reserva";
            this.bBaja.UseVisualStyleBackColor = true;
            this.bBaja.Click += new System.EventHandler(this.bBaja_Click);
            // 
            // Fregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::LabTP2.Properties.Resources.ciudad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 400);
            this.Controls.Add(this.bBaja);
            this.Controls.Add(this.lBregistro);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fregistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fregistro";
            this.Load += new System.EventHandler(this.Fregistro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lBregistro;
        public System.Windows.Forms.Button bBaja;
    }
}