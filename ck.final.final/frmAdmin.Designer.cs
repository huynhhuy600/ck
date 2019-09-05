namespace ck.final.final
{
    partial class frmAdmin
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
            this.dgvFlower = new System.Windows.Forms.DataGridView();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtyAdd = new MetroFramework.Controls.MetroTile();
            this.mtRefesh = new MetroFramework.Controls.MetroTile();
            this.mtlbloginAs = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characteristicsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theForestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlower
            // 
            this.dgvFlower.AllowUserToAddRows = false;
            this.dgvFlower.AutoGenerateColumns = false;
            this.dgvFlower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.characteristicsDataGridViewTextBoxColumn,
            this.theForestDataGridViewTextBoxColumn,
            this.DataGridViewComboBox});
            this.dgvFlower.DataSource = this.hoaBindingSource;
            this.dgvFlower.Location = new System.Drawing.Point(34, 204);
            this.dgvFlower.Name = "dgvFlower";
            this.dgvFlower.Size = new System.Drawing.Size(839, 236);
            this.dgvFlower.TabIndex = 5;
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(315, 77);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(75, 66);
            this.mtDelete.TabIndex = 4;
            this.mtDelete.Text = "Delete";
            this.mtDelete.TileImage = global::ck.final.final.Properties.Resources.svn_deleted;
            this.mtDelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDelete.UseTileImage = true;
            this.mtDelete.Click += new System.EventHandler(this.MtDelete_Click);
            // 
            // mtSave
            // 
            this.mtSave.BackColor = System.Drawing.Color.OrangeRed;
            this.mtSave.CustomBackground = true;
            this.mtSave.Location = new System.Drawing.Point(415, 77);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(75, 66);
            this.mtSave.TabIndex = 3;
            this.mtSave.Text = "Save";
            this.mtSave.TileImage = global::ck.final.final.Properties.Resources.svn_normal;
            this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSave.UseTileImage = true;
            this.mtSave.Click += new System.EventHandler(this.MtSave_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(224, 77);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(75, 66);
            this.mtEdit.TabIndex = 2;
            this.mtEdit.Text = "Edit";
            this.mtEdit.TileImage = global::ck.final.final.Properties.Resources._fixed;
            this.mtEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEdit.UseTileImage = true;
            this.mtEdit.Click += new System.EventHandler(this.MtEdit_Click);
            // 
            // mtyAdd
            // 
            this.mtyAdd.Location = new System.Drawing.Point(120, 77);
            this.mtyAdd.Name = "mtyAdd";
            this.mtyAdd.Size = new System.Drawing.Size(75, 66);
            this.mtyAdd.TabIndex = 1;
            this.mtyAdd.Text = "Add";
            this.mtyAdd.TileImage = global::ck.final.final.Properties.Resources.svn_added;
            this.mtyAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtyAdd.UseTileImage = true;
            this.mtyAdd.Click += new System.EventHandler(this.MtyAdd_Click);
            // 
            // mtRefesh
            // 
            this.mtRefesh.Location = new System.Drawing.Point(23, 77);
            this.mtRefesh.Name = "mtRefesh";
            this.mtRefesh.Size = new System.Drawing.Size(75, 66);
            this.mtRefesh.TabIndex = 0;
            this.mtRefesh.Text = "Refresh";
            this.mtRefesh.TileImage = global::ck.final.final.Properties.Resources.sticky;
            this.mtRefesh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRefesh.UseTileImage = true;
            this.mtRefesh.Click += new System.EventHandler(this.MtRefesh_Click);
            // 
            // mtlbloginAs
            // 
            this.mtlbloginAs.AutoSize = true;
            this.mtlbloginAs.Location = new System.Drawing.Point(567, 44);
            this.mtlbloginAs.Name = "mtlbloginAs";
            this.mtlbloginAs.Size = new System.Drawing.Size(66, 19);
            this.mtlbloginAs.TabIndex = 6;
            this.mtlbloginAs.Text = "Login As :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(663, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Name";
            // 
            // sttDataGridViewTextBoxColumn
            // 
            this.sttDataGridViewTextBoxColumn.DataPropertyName = "stt";
            this.sttDataGridViewTextBoxColumn.HeaderText = "stt";
            this.sttDataGridViewTextBoxColumn.Name = "sttDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // characteristicsDataGridViewTextBoxColumn
            // 
            this.characteristicsDataGridViewTextBoxColumn.DataPropertyName = "Characteristics";
            this.characteristicsDataGridViewTextBoxColumn.HeaderText = "Characteristics";
            this.characteristicsDataGridViewTextBoxColumn.Name = "characteristicsDataGridViewTextBoxColumn";
            // 
            // theForestDataGridViewTextBoxColumn
            // 
            this.theForestDataGridViewTextBoxColumn.DataPropertyName = "TheForest";
            this.theForestDataGridViewTextBoxColumn.HeaderText = "TheForest";
            this.theForestDataGridViewTextBoxColumn.Name = "theForestDataGridViewTextBoxColumn";
            // 
            // DataGridViewComboBox
            // 
            this.DataGridViewComboBox.DataPropertyName = "IDSpecies";
            this.DataGridViewComboBox.DataSource = this.speciesBindingSource;
            this.DataGridViewComboBox.DisplayMember = "SpeciesName";
            this.DataGridViewComboBox.HeaderText = "Species";
            this.DataGridViewComboBox.Name = "DataGridViewComboBox";
            this.DataGridViewComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataGridViewComboBox.ValueMember = "IDSpecies";
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataSource = typeof(ck.final.final.species);
            // 
            // hoaBindingSource
            // 
            this.hoaBindingSource.DataSource = typeof(ck.final.final.hoa);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 488);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtlbloginAs);
            this.Controls.Add(this.dgvFlower);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtyAdd);
            this.Controls.Add(this.mtRefesh);
            this.Name = "frmAdmin";
            this.Text = "Flower";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRefesh;
        private MetroFramework.Controls.MetroTile mtyAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtSave;
        private MetroFramework.Controls.MetroTile mtDelete;
        private System.Windows.Forms.DataGridView dgvFlower;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characteristicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theForestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataGridViewComboBox;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private System.Windows.Forms.BindingSource hoaBindingSource;
        private MetroFramework.Controls.MetroLabel mtlbloginAs;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

