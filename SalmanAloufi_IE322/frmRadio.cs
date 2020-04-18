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
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoRed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed2.Checked == true)
                RdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen2.Checked == true)
                RdoGreen2.ForeColor = Color.FromName("Green");
            else
                RdoGreen2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue2.Checked == true)
                RdoBlue2.ForeColor = Color.FromName("Blue");
            else
                RdoBlue2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow2.Checked == true)
                RdoYellow2.ForeColor = Color.FromName("Yellow");
            else
                RdoYellow2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
            RdoRed2.Checked = false;
            RdoGreen2.ForeColor = Color.FromArgb(0, 0, 0);
            RdoGreen2.Checked = false;
            RdoBlue2.ForeColor = Color.FromArgb(0, 0, 0);
            RdoBlue2.Checked = false;
            RdoYellow2.ForeColor = Color.FromArgb(0, 0, 0);
            RdoYellow2.Checked = false;
        }
    }
}
