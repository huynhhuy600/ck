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
    public partial class frmAddFlower : MetroFramework.Forms.MetroForm
    {
        public frmAddFlower(hoa obj)
        {
            InitializeComponent();
            bindingSourceFlower.DataSource = obj;
            if (chkForest.CheckState == CheckState.Checked)//kiểm tra có đánh dâu vào Foreset không
                chkForest.Text = "Forest";
            else if (chkForest.CheckState == CheckState.Checked)
                chkForest.Text = "NonForest";
            else
                chkForest.Text = "???";
        }

        public hoa hoa { get { return bindingSourceFlower.Current as hoa; } }

        private void FrmAddFlower_Load(object sender, EventArgs e)
        {
            cboSpecies.DisplayMember = "SpeciesName";
            cboSpecies.ValueMember = "IDSpecies";
            using (DbEntities db = new DbEntities())
            {
                cboSpecies.DataSource =db.species.ToList();;

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bindingSourceFlower.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void ChkForest_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
