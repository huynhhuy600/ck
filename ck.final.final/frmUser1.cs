using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ck.final.final
{
    public partial class frmUser1 : MetroFramework.Forms.MetroForm
    {
        public frmUser1()
        {
            InitializeComponent();
        }
        DbEntities db = new DbEntities();
        private void MttxtShow_Click(object sender, EventArgs e)
        {
            hoaDataGridView.DataSource = db.hoas.ToList();

        }

        private void MttxtSearch_TextChanged(object sender, EventArgs e)
        {
            hoaDataGridView.DataSource = db.hoas.Where(X => X.Name.Contains(mttxtSearch.Text)||X.color.Contains(mttxtSearch.Text)).ToList();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.

            Bitmap bm = new Bitmap(this.hoaDataGridView.Width, this.hoaDataGridView.Height);
            hoaDataGridView.DrawToBitmap(bm, new Rectangle(0, 0, this.hoaDataGridView.Width, this.hoaDataGridView.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void FrmUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
