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
    public partial class frmAdmin : MetroFramework.Forms.MetroForm
    {
        public frmAdmin(string name)
        {
            InitializeComponent();
            metroLabel2.Text = name;//hiển thị quyền đang đăng nhập
        }
        //sử dụng Linq
        private async void MtyAdd_Click(object sender, EventArgs e)
                {
            using (frmAddFlower frm = new frmAddFlower(new hoa() { TheForest = false}))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        hoaBindingSource.Add(frm.hoa);
                        db.hoas.Add(frm.hoa);
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        DbEntities db;

        private void MtRefesh_Click(object sender, EventArgs e)
        {
            db = new DbEntities();
            Cursor.Current = Cursors.WaitCursor;
            hoaBindingSource.DataSource = db.hoas.ToList();
            speciesBindingSource.DataSource = db.species.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            hoaBindingSource.DataSource = db.hoas.ToList();
            speciesBindingSource.DataSource = db.species.ToList();
        }

        private async  void MtEdit_Click(object sender, EventArgs e)
        {
            hoa obj = hoaBindingSource.Current as hoa;
            if(obj != null)// kiểm tra data obj khác nulll thì chạy
            {
                using (frmAddFlower frm = new frmAddFlower(obj))
                {
                    if(frm.ShowDialog() == DialogResult.OK )
                    {
                          try
                        {
                            hoaBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void MtDelete_Click(object sender, EventArgs e)
        {
            if(  MessageBox.Show("Do you want delete this record","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //kiererm tra vị trí của rows trong datagrid
                int rows = dgvFlower.RowCount;
                for(int i = rows-1; i >= 0; i--)// for chat tất cả các rows trong dgvFlower
                {
                    if(dgvFlower.Rows[i].Selected)//vị trí rows[i] được chọn trong dgvFlower
                    {
                        db.hoas.Remove(dgvFlower.Rows[i].DataBoundItem as hoa);
                        hoaBindingSource.RemoveAt(dgvFlower.Rows[i].Index);
                    }
                }
            }
        }

        private async void MtSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do You Want To Save The Changes", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hoaBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
