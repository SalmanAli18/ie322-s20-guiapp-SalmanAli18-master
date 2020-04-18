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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            cmbDays.Items.Add("Sunday");
            cmbDays.Items.Add("Monday");
            cmbDays.Items.Add("Tuesday");
            cmbDays.Items.Add("Wednesday");
            cmbDays.Items.Add("Thursday");
            cmbDays.Items.Add("Friday");
            cmbDays.Items.Add("Saturday");

        }

        private void BtnBack3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.Text);
        }

        private void BtnRemoveByN_Click(object sender, EventArgs e)
        {
            cmbDays.Items.Remove("Friday");
        }

        private void BtnRemoveByI_Click(object sender, EventArgs e)
        {
            cmbDays.Items.RemoveAt(1);
        }

        private void BtnRemoveLI_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 2)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }
    }
}
