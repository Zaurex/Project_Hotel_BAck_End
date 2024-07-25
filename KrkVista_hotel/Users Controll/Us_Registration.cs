using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KrkVista_hotel.Users_Controll
{
    public partial class Us_Registration : UserControl
    {
        function fn = new function();
        String query;
        public Us_Registration()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    if (sdr.GetFieldType(i) == typeof(string))
                    {
                        combo.Items.Add(sdr.GetString(i));
                    }
                    else
                    {
                        combo.Items.Add(sdr.GetValue(i).ToString());
                    }
                }
            }
            sdr.Close();
        }
        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomnumber.Items.Clear();
            query = "select roomNm from rooms where bedTp = '" + txtbedTp.Text + "' and roomTp = '" + txtroomTp.Text + "' and booking = 'NO'";
            setComboBox(query, txtRoomnumber);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Handle label3 click event
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Handle label11 click event
        }

        int roomid;
        private void txtRoomnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomId from rooms where roomNm = '" + txtRoomnumber.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtPricea.Text = ds.Tables[0].Rows[0]["price"].ToString();
                roomid = int.Parse(ds.Tables[0].Rows[0]["roomId"].ToString());
            }
        }

        private void txtbedTp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtroomTp.SelectedIndex = -1;
            txtRoomnumber.Items.Clear();
        }

        private void AttachButtom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNameSurn.Text) && !string.IsNullOrWhiteSpace(txtPhonenmbr.Text) &&
                !string.IsNullOrWhiteSpace(txtSexx.Text) && !string.IsNullOrWhiteSpace(txtDatebirth.Text) &&
                !string.IsNullOrWhiteSpace(txtCeckInn.Text) && !string.IsNullOrWhiteSpace(txtPricea.Text))
            {
                String name = txtNameSurn.Text;
                Int64 phonen = Int64.Parse(txtPhonenmbr.Text);
                String gender = txtSexx.Text;
                String dateb = txtDatebirth.Text;
                String checkin = txtCheckin.Text;

                query = $"insert into customerinf (CustName, PhoneNm, Sex, Dbirth, Checkin, roomid) values ('{name}', '{phonen}', '{gender}', '{dateb}', '{checkin}', {roomid})";
                fn.setData(query, "Room " + txtRoomnumber.Text + " booking successful.");
            }
            else
            {
                MessageBox.Show("Invalid", "Please fill all the boxes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
