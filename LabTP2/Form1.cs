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
    public partial class Fprincipal : Form
    {
        Trivago gestor = new Trivago(100);
        Alojamiento[] alojamientos;
        public Fprincipal()
        {
            InitializeComponent();
            this.Show();
        }
       
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fregistrar fregistro = new Fregistrar();
            fregistro.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Fprincipal_Load(object sender, EventArgs e)
        {
            cBalojamiento.SelectedIndex = 0;
            cBestrellas.SelectedIndex = 0;
            cBhabit.SelectedIndex = 0;
            cBcamas.SelectedIndex = 0;
            FprecioBase fpb = new FprecioBase();

            decimal precio = 100;
            if (fpb.ShowDialog() == DialogResult.OK)
            {
                precio = fpb.tBprecioBase.Text != "" ? Convert.ToDecimal(fpb.tBprecioBase.Text) : precio;
            }
            gestor = new Trivago(precio);

            alojamientos=gestor.MostrarAlojamientos();
            dataGridView1.ColumnCount = 2;

            llenarDataGrid(alojamientos);
            
            
            //queda pendiente formatear el datagrid con la cantidad de resultados de la busqueda
            


        }



        private void cBalojamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilita los combobox correspondientes
            cBestrellas.Visible = cBalojamiento.SelectedIndex == 1;
            cBestrellas.Enabled = cBalojamiento.SelectedIndex == 1;
            cBhabit.Visible = cBalojamiento.SelectedIndex == 1;
            cBhabit.Enabled = cBalojamiento.SelectedIndex == 1;
            cBcamas.Visible = cBalojamiento.SelectedIndex == 2;
            cBcamas.Enabled = cBalojamiento.SelectedIndex == 2;
            Alojamiento[] lista = null;

            switch (cBalojamiento.SelectedIndex)
            {
                case 0:
                    lista = gestor.MostrarAlojamientos();
                    break;
                case 1:
                    Habitacion h = new Habitacion(cBhabit.SelectedIndex, "", cBestrellas.SelectedIndex+1, "");
                    lista = gestor.MostrarAlojamientos(h);
                    break;
                case 2:
                    Casa c = new Casa(cBcamas.SelectedIndex, "", new bool[] { false }, 1);
                    lista = gestor.MostrarAlojamientos(c);
                    break;
            }
            llenarDataGrid(lista);
            
            
        }


        void llenarDataGrid(Alojamiento[] alojamientos)
        {
            dataGridView1.Rows.Clear();
            foreach (Alojamiento a in alojamientos)
            {
                dataGridView1.Rows.Add(a.Direccion, a.PrecioPorDia());
            }
        }

        private void Fprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            gestor.BackUp();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAlojamiento fa = new fAlojamiento("agregar");
            fa.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAlojamiento fa = new fAlojamiento("modif");
            fa.ShowDialog();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bajaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fAlojamiento fa = new fAlojamiento("baja");
            fa.ShowDialog();
        }

        private void cBcamas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBalojamiento_SelectedIndexChanged(sender, e);
        }

        private void cBhabit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBalojamiento_SelectedIndexChanged(sender, e);
        }

        private void cBestrellas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBalojamiento_SelectedIndexChanged(sender, e);
        }
    }
}
