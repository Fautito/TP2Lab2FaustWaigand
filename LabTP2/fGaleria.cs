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
    public partial class fGaleria : Form
    {
        public fGaleria(List<Image> imagenes)
        {
            InitializeComponent();
            galeria = imagenes;
        }
        List<Image> galeria;
        private void fGaleria_Load(object sender, EventArgs e)
        {
            foreach (Image i in galeria)
                imageList1.Images.Add(i);
            //imageList1.ImageSize = label1.Size;
            label1.ImageIndex = i;
        }
        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            i++;
            if (i<=galeria.Count-1)
            {
                label1.ImageIndex = i; 
            }
            else
            {
                i = 0; 
                label1.ImageIndex = 0;
            }

        }
    }
}
