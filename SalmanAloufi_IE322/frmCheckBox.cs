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
    public partial class frmCheckBox : Form
        
    {
        
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void BtnBack2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (CheckCoffee.Checked == true)
            {
                msg = CheckCoffee.Text;
            }
            if (CheckDonut.Checked == true)
            {
                msg = msg + " " + CheckDonut.Text;
            }
            if (CheckBrownie.Checked == true)
            {
                msg = msg + " " + CheckBrownie.Text;
            }
    
            if (msg.Length > 0)
                MessageBox.Show(msg + " ordered");
            else
                MessageBox.Show("Nothing ordered");
        }
    }
}
