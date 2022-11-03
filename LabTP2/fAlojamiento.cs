using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTP2
{
    public partial class fAlojamiento : Form
    {

        public List<Image>listaimagenes=new List<Image>();

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
                    lAgregarImagen.Enabled = true;
                    lAgregarImagen.Visible = true;


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
                    lAgregarImagen.Enabled = true;
                    lAgregarImagen.Visible = true;
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
                    lAgregarImagen.Visible = false;
                    lAgregarImagen.Enabled = false;
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
            if (bModif.Visible)
            {
                Alojamiento aloja = (Alojamiento)cbAlojamientos.SelectedItem;
                listaimagenes = aloja.listaImagenes;
                if (aloja.GetType() == typeof(Casa))
                {
                    comboBox1.SelectedIndex = 1;
                    gbCasa.Enabled = true;
                    gbCasa.Visible = true;
                    gbHotel.Enabled = false;
                    gbHotel.Visible = false;

                    tBDIreccion.Text = aloja.Direccion;
                    numericUpDown1.Value = aloja.Capacidad;
                    chBCochera.Checked = ((Casa)aloja).Servicios[0];
                    chBPileta.Checked = ((Casa)aloja).Servicios[1];
                    chBWifi.Checked = ((Casa)aloja).Servicios[2];
                    chBLimpieza.Checked = ((Casa)aloja).Servicios[3];
                    chBDesayuno.Checked = ((Casa)aloja).Servicios[4];
                    chBMascotas.Checked = ((Casa)aloja).Servicios[5];
                    numericUpDown2.Value= ((Casa)aloja).DiasMinimos;
                }
                else if (aloja.GetType() == typeof(Habitacion))
                {
                    comboBox1.SelectedIndex = 0;
                    gbCasa.Enabled = false;
                    gbCasa.Visible = false;
                    gbHotel.Enabled = true;
                    gbHotel.Visible = true;

                    tBDIreccion.Text = aloja.Direccion;
                    numericUpDown1.Value = aloja.Capacidad;
                    comboBox2.SelectedIndex = ((Habitacion)aloja).Estrellas - 2;
                    tBNumHab.Text = ((Habitacion)aloja).NumeroHabitacion;
                }


            }

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

        private void lAgregarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "archivo imagen (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.InitialDirectory = Application.StartupPath;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                
                Image image = Image.FromFile(path);
                if (listaimagenes!=null && listaimagenes.Count <= 5)
                {
                    listaimagenes.Add(image);

                }
                else{
                    MessageBox.Show("Ya nl se pueden agregar imagenes", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
