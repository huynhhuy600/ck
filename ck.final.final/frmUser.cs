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
    public partial class frmUser : Form
    {
        //kết nối sql
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O4PNV5S;Initial Catalog=CK;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;

        
        //hiển thị dữ liệu
        public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from hoa", con);//truy xuất dữ liệu trong sql
            dt = new DataTable();
            adpt.Fill(dt);
            dgvSearch.DataSource = dt;//đưa dữ liệu vào bảng ảo dt
            con.Close();
        }
        public frmUser()
        {
            InitializeComponent();
            DisplayValue();
            using (DbEntities db = new DbEntities())
            {
                hoaBindingSource.DataSource = db.hoas.ToList();
            }
        }
        
        private void MttxtSearch_Click(object sender, EventArgs e)
        {

            SearchData(mttxtSearch.Text);
        }
        public void SearchData(string search)
        {
            con.Open();
            string query = "select * from hoa where name like  '%" + search + "%'";//chuỗi để tiefm kiếm dữ liệu
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvSearch.DataSource = dt;
            con.Close();
        }


        Bitmap bitmap;
        private void BtnPrint_Click(object sender, EventArgs e)
        {
          
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            
            Bitmap bm = new Bitmap(this.dgvSearch.Width, this.dgvSearch.Height);
            dgvSearch.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvSearch.Width, this.dgvSearch.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
