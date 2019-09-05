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
    public partial class test : MetroFramework.Forms.MetroForm
    {
        public test(taikhoan obj)
        {
            InitializeComponent();
            bindingSourceTK.DataSource = obj;
        }
        public taikhoan taikhoan { get { return bindingSourceTK.Current as taikhoan; } }

        private void MtbtnSave_Click(object sender, EventArgs e)
        {
            bindingSourceTK.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
