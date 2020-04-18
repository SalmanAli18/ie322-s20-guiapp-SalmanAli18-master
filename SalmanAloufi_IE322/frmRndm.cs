using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalmanAloufi_IE322
{
    public partial class frmRndm : Form
    {
        Random y = new Random();
        public frmRndm()
        {
            InitializeComponent();
        }

        private void BtnBack4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void frmRndm_Load(object sender, EventArgs e)
        {

        }

        private void BtnRndmNmbr_Click(object sender, EventArgs e)
        {
            BtnRndmNmbr.Text = Convert.ToString(y.Next(1, 10));
        }

        private void BtnGnrtRndmClr_Click(object sender, EventArgs e)
        {
            int r = y.Next(0, 255);
            int g = y.Next(0, 255);
            int b = y.Next(0, 255);
            LblRGB.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
            BtnGnrtRndmClr.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
