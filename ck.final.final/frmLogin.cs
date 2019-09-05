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
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;

namespace ck.final.final
{
    public partial class frmLogin : MaterialForm
    {
        //kết nối sql severs
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O4PNV5S;Initial Catalog=CK;Integrated Security=True");
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu vào  để so sánh
            string query = "select userpower from taikhoan where username ='" + txtName.Text + "'and userpassword = '" + txtPass.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                this.Hide();
                if(dt.Rows[0][0].ToString() == "admin" || dt.Rows[0][0].ToString() == "edit")// kiếm tra nếu userpower lầ admin thì truyền dữ liệu qua form admin
                {
                    frmAdmin frm = new frmAdmin(dt.Rows[0][0].ToString());
                    frm.Show();
                }
                if(dt.Rows[0][0].ToString() == "guest" || dt.Rows[0][0].ToString() == "")
                {
                    frmUser1 frmUser = new frmUser1();
                    frmUser.Show();
                }                             
            }
            else
            {
                MessageBox.Show("Check your user and pass");
            }
         
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            taikhoanBindingSource.DataSource = db.taikhoans.ToList();
        }
        // đăng ki tài khoản mới
        DbEntities db = new DbEntities();
        private  void MtbtnResiger_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             frmRegistrationcs frm = new frmRegistrationcs();
             frm.Show();*/
            using (frmReg frm = new frmReg(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    taikhoanBindingSource.DataSource = db.taikhoans.ToList();
                    
            }
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
