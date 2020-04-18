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
    public partial class frmpicture : Form
    {
        public frmpicture()
        {
            InitializeComponent();
        }

        private void BtnLoadPic_Click(object sender, EventArgs e)
        {
            try
            {
                PicTry.Image = Image.FromFile("C:\\Users\\WIN-10\\Desktop\\IE LOGO4_19112019.jpg");
            }
            catch
            { MessageBox.Show("Image file not found!");
            }
        }

        private void BtnBack6_Click(object sender, EventArgs e)
        {

        }

        private void frmpicture_Load(object sender, EventArgs e)
        {

        }
    }
}
