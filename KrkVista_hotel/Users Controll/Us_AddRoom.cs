using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrkVista_hotel.Users_Controll
{
    public partial class Us_AddRoom : UserControl
    {
        
        function fn = new function();
        String quaery;
        public Us_AddRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Us_AddRoom_Load(object sender, EventArgs e)
        {
            quaery = "select * from rooms";
            DataSet ds = fn.getData(quaery);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtBedTp.Text != "" && txtPrice.Text != "" && txtRoomNo.Text != "" && txtRoomTp.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String roomtp = txtRoomTp.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                String bed = txtBedTp.Text;


                quaery = "Insert into rooms (roomNm, roomTp, bedTp, price) values ('"+roomno+"', '"+roomtp+"', '"+bed+"', '"+price+"')";
                fn.setData(quaery, "Added");
                Us_AddRoom_Load(this, null);
                clearall();
            }
            else                                       
            {
                
                MessageBox.Show("Invalid info");
                
            }
        }

        public void clearall()
        {
            txtRoomNo.Clear();
            txtRoomTp.SelectedIndex = -1;
            txtBedTp.SelectedIndex = -1;
            txtPrice.Clear();   

        }
    }
}
