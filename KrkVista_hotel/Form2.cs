using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrkVista_hotel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            us_Registration1.Visible = true;
            us_Registration1.BringToFront();
        }

        private void BtmRooms_Click(object sender, EventArgs e)
        {
            us_AddRoom1.Visible = true;
            us_AddRoom1.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            us_Registration1.Visible = false;
            BtmRooms.PerformClick();
        }

        private void us_AddRoom1_Load(object sender, EventArgs e)
        {

        }
    }
}
