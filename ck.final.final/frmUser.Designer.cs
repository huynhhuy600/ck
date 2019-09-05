namespace ck.final.final
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.mttxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characteristicsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theForestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToOrderColumns = true;
            this.dgvSearch.AutoGenerateColumns = false;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.characteristicsDataGridViewTextBoxColumn,
            this.theForestDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.species});
            this.dgvSearch.DataSource = this.hoaBindingSource;
            this.dgvSearch.Location = new System.Drawing.Point(12, 136);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(655, 230);
            this.dgvSearch.TabIndex = 0;
            // 
            // mttxtSearch
            // 
            this.mttxtSearch.Location = new System.Drawing.Point(153, 38);
            this.mttxtSearch.Name = "mttxtSearch";
            this.mttxtSearch.Size = new System.Drawing.Size(164, 23);
            this.mttxtSearch.TabIndex = 1;
            this.mttxtSearch.Click += new System.EventHandler(this.MttxtSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(564, 34);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "&Print ";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Search By Name";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // sttDataGridViewTextBoxColumn
            // 
            this.sttDataGridViewTextBoxColumn.DataPropertyName = "stt";
            this.sttDataGridViewTextBoxColumn.HeaderText = "stt";
            this.sttDataGridViewTextBoxColumn.Name = "sttDataGridViewTextBoxColumn";
            this.sttDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // characteristicsDataGridViewTextBoxColumn
            // 
            this.characteristicsDataGridViewTextBoxColumn.DataPropertyName = "Characteristics";
            this.characteristicsDataGridViewTextBoxColumn.HeaderText = "Characteristics";
            this.characteristicsDataGridViewTextBoxColumn.Name = "characteristicsDataGridViewTextBoxColumn";
            this.characteristicsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // theForestDataGridViewTextBoxColumn
            // 
            this.theForestDataGridViewTextBoxColumn.DataPropertyName = "TheForest";
            this.theForestDataGridViewTextBoxColumn.HeaderText = "TheForest";
            this.theForestDataGridViewTextBoxColumn.Name = "theForestDataGridViewTextBoxColumn";
            this.theForestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // species
            // 
            this.species.DataPropertyName = "species";
            this.species.HeaderText = "species";
            this.species.Name = "species";
            this.species.ReadOnly = true;
            // 
            // hoaBindingSource
            // 
            this.hoaBindingSource.DataSource = typeof(ck.final.final.hoa);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.mttxtSearch);
            this.Controls.Add(this.dgvSearch);
            this.Name = "frmUser";
            this.Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private MetroFramework.Controls.MetroTextBox mttxtSearch;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource hoaBindingSource;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characteristicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theForestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn species;
    }
}