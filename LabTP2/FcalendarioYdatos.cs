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
    public partial class FcalendarioYdatos : Form
    {
        //no se puede inicializar el componente con parametro tipo alojamiento xq hay problemas de accesibilidad "el parametro tiene mas/menos accesibilidad que el metodo que lo utiliza"
        public FcalendarioYdatos()
        {
            InitializeComponent();
        }

        private void FcalendarioYdatos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
