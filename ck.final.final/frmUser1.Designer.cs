namespace ck.final.final
{
    partial class frmUser1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser1));
            this.hoaDataGridView = new System.Windows.Forms.DataGridView();
            this.mttxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mttxtShow = new MetroFramework.Controls.MetroButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.hoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characteristicsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theForestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDataGridView
            // 
            this.hoaDataGridView.AllowUserToAddRows = false;
            this.hoaDataGridView.AllowUserToDeleteRows = false;
            this.hoaDataGridView.AutoGenerateColumns = false;
            this.hoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.characteristicsDataGridViewTextBoxColumn,
            this.theForestDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn});
            this.hoaDataGridView.DataSource = this.hoaBindingSource;
            this.hoaDataGridView.Location = new System.Drawing.Point(12, 178);
            this.hoaDataGridView.Name = "hoaDataGridView";
            this.hoaDataGridView.ReadOnly = true;
            this.hoaDataGridView.Size = new System.Drawing.Size(566, 220);
            this.hoaDataGridView.TabIndex = 1;
            // 
            // mttxtSearch
            // 
            this.mttxtSearch.Location = new System.Drawing.Point(166, 80);
            this.mttxtSearch.Name = "mttxtSearch";
            this.mttxtSearch.Size = new System.Drawing.Size(191, 23);
            this.mttxtSearch.TabIndex = 3;
            this.mttxtSearch.TextChanged += new System.EventHandler(this.MttxtSearch_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "SearchByName:";
            // 
            // mttxtShow
            // 
            this.mttxtShow.Location = new System.Drawing.Point(338, 149);
            this.mttxtShow.Name = "mttxtShow";
            this.mttxtShow.Size = new System.Drawing.Size(75, 23);
            this.mttxtShow.TabIndex = 5;
            this.mttxtShow.Text = "&Show";
            this.mttxtShow.Click += new System.EventHandler(this.MttxtShow_Click);
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
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(37, 149);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 23);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "&Print ";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // hoaBindingSource
            // 
            this.hoaBindingSource.DataSource = typeof(ck.final.final.hoa);
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
            // frmUser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.mttxtShow);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mttxtSearch);
            this.Controls.Add(this.hoaDataGridView);
            this.Name = "frmUser1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmUser1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView hoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private MetroFramework.Controls.MetroTextBox mttxtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mttxtShow;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroButton btnPrint;
        private System.Windows.Forms.BindingSource hoaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characteristicsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theForestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
    }
}