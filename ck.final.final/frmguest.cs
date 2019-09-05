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
    public partial class dgvSearch : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O4PNV5S;Initial Catalog=CK;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        
        public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from hoa", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvGuest.DataSource = dt;
            con.Close();
        }
        public dgvSearch()
        {
            InitializeComponent();
            DisplayValue();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text);
        }
        public void SearchData(string search)
        {
            con.Open();
            string query = "select * form hoa where Name like  '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dgvGuest.DataSource = dt;
            con.Close();
        }
    }
}
