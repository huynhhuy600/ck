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
    public partial class frmReg : MetroFramework.Forms.MetroForm
    {
        public frmReg(taikhoan obj)
        {
            InitializeComponent();
            db = new DbEntities();
            if (obj == null)
            {
                TKbindingSource.DataSource = new taikhoan();
                db.taikhoans.Add(TKbindingSource.Current as taikhoan);

            }
            else
            {
                TKbindingSource.DataSource = obj;
                db.taikhoans.Attach(TKbindingSource.Current as taikhoan);
            }
        }
        DbEntities db;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                if(string.IsNullOrEmpty(mttxtUserName.Text))
                {
                    MessageBox.Show("nhap vao", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mttxtUserName.Focus();
                    e.Cancel = true;
                    return;

                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
