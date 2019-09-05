namespace ck.final.final
{
    partial class frmAddFlower
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtID = new MetroFramework.Controls.MetroLabel();
            this.mtName = new MetroFramework.Controls.MetroLabel();
            this.mtForest = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtColor = new MetroFramework.Controls.MetroLabel();
            this.mtCharacteristics = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.chkForest = new MetroFramework.Controls.MetroCheckBox();
            this.cboSpecies = new MetroFramework.Controls.MetroComboBox();
            this.txtColor = new MetroFramework.Controls.MetroTextBox();
            this.txtCharacteristics = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.bindingSourceFlower = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlower)).BeginInit();
            this.SuspendLayout();
            // 
            // mtID
            // 
            this.mtID.AutoSize = true;
            this.mtID.Location = new System.Drawing.Point(23, 71);
            this.mtID.Name = "mtID";
            this.mtID.Size = new System.Drawing.Size(71, 19);
            this.mtID.TabIndex = 1;
            this.mtID.Text = "IDFlower : ";
            // 
            // mtName
            // 
            this.mtName.AutoSize = true;
            this.mtName.Location = new System.Drawing.Point(23, 102);
            this.mtName.Name = "mtName";
            this.mtName.Size = new System.Drawing.Size(84, 19);
            this.mtName.TabIndex = 1;
            this.mtName.Text = "FlowerName";
            // 
            // mtForest
            // 
            this.mtForest.AutoSize = true;
            this.mtForest.Location = new System.Drawing.Point(23, 138);
            this.mtForest.Name = "mtForest";
            this.mtForest.Size = new System.Drawing.Size(66, 19);
            this.mtForest.TabIndex = 1;
            this.mtForest.Text = "TheForest";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 177);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Species";
            // 
            // mtColor
            // 
            this.mtColor.AutoSize = true;
            this.mtColor.Location = new System.Drawing.Point(23, 228);
            this.mtColor.Name = "mtColor";
            this.mtColor.Size = new System.Drawing.Size(42, 19);
            this.mtColor.TabIndex = 1;
            this.mtColor.Text = "Color";
            // 
            // mtCharacteristics
            // 
            this.mtCharacteristics.AutoSize = true;
            this.mtCharacteristics.Location = new System.Drawing.Point(23, 285);
            this.mtCharacteristics.Name = "mtCharacteristics";
            this.mtCharacteristics.Size = new System.Drawing.Size(99, 19);
            this.mtCharacteristics.TabIndex = 1;
            this.mtCharacteristics.Text = "Characteristics :";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFlower, "ID", true));
            this.txtID.Location = new System.Drawing.Point(139, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(186, 23);
            this.txtID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFlower, "Name", true));
            this.txtName.Location = new System.Drawing.Point(139, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 23);
            this.txtName.TabIndex = 2;
            // 
            // chkForest
            // 
            this.chkForest.AutoSize = true;
            this.chkForest.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceFlower, "TheForest", true));
            this.chkForest.Location = new System.Drawing.Point(139, 141);
            this.chkForest.Name = "chkForest";
            this.chkForest.Size = new System.Drawing.Size(55, 15);
            this.chkForest.TabIndex = 3;
            this.chkForest.Text = "Forest";
            this.chkForest.UseVisualStyleBackColor = true;
            this.chkForest.CheckedChanged += new System.EventHandler(this.ChkForest_CheckedChanged);
            // 
            // cboSpecies
            // 
            this.cboSpecies.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceFlower, "species", true));
            this.cboSpecies.FormattingEnabled = true;
            this.cboSpecies.ItemHeight = 23;
            this.cboSpecies.Location = new System.Drawing.Point(139, 177);
            this.cboSpecies.Name = "cboSpecies";
            this.cboSpecies.Size = new System.Drawing.Size(121, 29);
            this.cboSpecies.TabIndex = 4;
            // 
            // txtColor
            // 
            this.txtColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFlower, "color", true));
            this.txtColor.Location = new System.Drawing.Point(139, 228);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(186, 23);
            this.txtColor.TabIndex = 2;
            // 
            // txtCharacteristics
            // 
            this.txtCharacteristics.AllowDrop = true;
            this.txtCharacteristics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCharacteristics.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFlower, "Characteristics", true));
            this.txtCharacteristics.Location = new System.Drawing.Point(139, 285);
            this.txtCharacteristics.Multiline = true;
            this.txtCharacteristics.Name = "txtCharacteristics";
            this.txtCharacteristics.Size = new System.Drawing.Size(239, 53);
            this.txtCharacteristics.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // bindingSourceFlower
            // 
            this.bindingSourceFlower.DataSource = typeof(ck.final.final.hoa);
            // 
            // frmAddFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 416);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboSpecies);
            this.Controls.Add(this.chkForest);
            this.Controls.Add(this.txtCharacteristics);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.mtCharacteristics);
            this.Controls.Add(this.mtColor);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mtForest);
            this.Controls.Add(this.mtName);
            this.Controls.Add(this.mtID);
            this.Name = "frmAddFlower";
            this.Text = "Flower Info";
            this.Load += new System.EventHandler(this.FrmAddFlower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mtID;
        private MetroFramework.Controls.MetroLabel mtName;
        private MetroFramework.Controls.MetroLabel mtForest;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel mtColor;
        private MetroFramework.Controls.MetroLabel mtCharacteristics;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroCheckBox chkForest;
        private MetroFramework.Controls.MetroComboBox cboSpecies;
        private MetroFramework.Controls.MetroTextBox txtColor;
        private MetroFramework.Controls.MetroTextBox txtCharacteristics;
        private System.Windows.Forms.BindingSource bindingSourceFlower;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}