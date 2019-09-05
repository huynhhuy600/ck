using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ck.final.final
{
    public partial class frmRegistrationcs : MetroFramework.Forms.MetroForm
    {
        //kết nối sql
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-O4PNV5S;Initial Catalog=CK;Integrated Security=True");
        public frmRegistrationcs()
        {
            InitializeComponent();
        }
        //tạo nút save dữ liệ
        private void MtbtnSave_Click(object sender, EventArgs e)
        {
            //kiểm tra có nhập dữ liệu vào chưa
            if (mttxtUserName.Text == "" || mttxtPass.Text == "")
                MessageBox.Show("please fill");
            else if (mttxtPass.Text != mttxtConfirmPass.Text)
                MessageBox.Show("Pass not match");
            else
            {
                // lưu dữ liệu vào sql
                con.Open();
                SqlCommand cmd = new SqlCommand("UserAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", mttxtUserName.Text.Trim());
                cmd.Parameters.AddWithValue("@userpassword", mttxtPass.Text.Trim());
                cmd.Parameters.AddWithValue("@name", mttxtName.Text.Trim());
                cmd.Parameters.AddWithValue("@address", mttxtAddress.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registartion is successfull");
                clean();
            }
        }
        //làm sạch trong các text
        void clean()
        {
            mttxtUserName.Text = mttxtPass.Text = mttxtName.Text = mttxtAddress.Text = mttxtConfirmPass.Text = "";
        }

        private void MtbtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
         
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
