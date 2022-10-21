using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTP2
{
    public partial class fAlojamiento : Form
    {
        public fAlojamiento(string op)
        {
            InitializeComponent();
            gbCasa.Enabled = false;
            gbCasa.Visible = false;
            gbHotel.Enabled = false;
            gbHotel.Visible = false;
            switch (op)
            {
                case "agregar":
                    cbAlojamientos.Visible = false;
                    cbAlojamientos.Enabled = false;
                    bModif.Visible = false;
                    bModif.Enabled = false;
                    bAgregar.Visible = true;
                    bAgregar.Enabled = true;
                    bEliminar.Enabled = false;
                    bEliminar.Visible = false;

                    break;
                case "modif":
                    cbAlojamientos.Visible = true;
                    cbAlojamientos.Enabled = true;
                    bModif.Visible = true;
                    bModif.Enabled = true;
                    bAgregar.Visible = false;
                    bAgregar.Enabled = false;
                    bEliminar.Enabled = false;
                    bEliminar.Visible = false;
                    break;
                case "baja":
                    cbAlojamientos.Visible = true;
                    cbAlojamientos.Enabled = true;
                    bModif.Visible = false;
                    bModif.Enabled = false;
                    bAgregar.Visible = false;
                    bAgregar.Enabled = false;
                    bEliminar.Enabled = true;
                    bEliminar.Visible = true;
                    this.Height = 250;
                    label1.Visible = false;
                    label2.Visible = false;

                    label3.Visible = false;
                    comboBox1.Visible = false;
                    numericUpDown1.Visible = false;
                    tBDIreccion.Visible=false;
                    break;
            }
        }
       

        private void fAlojamiento_Load(object sender, EventArgs e)
        {

        }

        private void cbAlojamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Casa")
            {
                gbCasa.Enabled = true;
                gbCasa.Visible = true;
                gbHotel.Enabled = false;
                gbHotel.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Habitacion")
            {
                gbCasa.Enabled = false;
                gbCasa.Visible = false;
                gbHotel.Enabled = true;
                gbHotel.Visible = true;
            }
            else
            {
                gbCasa.Enabled = false;
                gbCasa.Visible = false;
                gbHotel.Enabled = false;
                gbHotel.Visible = false;
            }
        }

        private void gbCasa_Enter(object sender, EventArgs e)
        {

        }
    }
}
