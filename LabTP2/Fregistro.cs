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
    public partial class Fregistro : Form
    {
        public Fregistro()
        {
            InitializeComponent();
        }

        private void Fregistro_Load(object sender, EventArgs e)
        {

        }
        Reserva r;
        private void bBaja_Click(object sender, EventArgs e)
        {
            r = (Reserva)lBregistro.SelectedItem;
            if(MessageBox.Show("Desea cancelar la reserva?", $"Cancelar reserva en {r.alojamiento.Direccion}", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                lBregistro.SelectedItem = null;
            }
        }

        
    }
}
