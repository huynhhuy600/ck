namespace ck.final.final
{
    partial class frmReg
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
            this.mtbtnSave = new MetroFramework.Controls.MetroButton();
            this.mttxtName = new MetroFramework.Controls.MetroTextBox();
            this.TKbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mttxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mttxtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mttxtUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TKbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbtnSave
            // 
            this.mtbtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mtbtnSave.Location = new System.Drawing.Point(184, 329);
            this.mtbtnSave.Name = "mtbtnSave";
            this.mtbtnSave.Size = new System.Drawing.Size(75, 23);
            this.mtbtnSave.TabIndex = 15;
            this.mtbtnSave.Text = "Save";
            // 
            // mttxtName
            // 
            this.mttxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TKbindingSource, "name", true));
            this.mttxtName.Location = new System.Drawing.Point(184, 187);
            this.mttxtName.Name = "mttxtName";
            this.mttxtName.Size = new System.Drawing.Size(196, 23);
            this.mttxtName.TabIndex = 10;
            // 
            // TKbindingSource
            // 
            this.TKbindingSource.DataSource = typeof(ck.final.final.taikhoan);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 191);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Name : ";
            // 
            // mttxtAddress
            // 
            this.mttxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TKbindingSource, "address", true));
            this.mttxtAddress.Location = new System.Drawing.Point(184, 236);
            this.mttxtAddress.Multiline = true;
            this.mttxtAddress.Name = "mttxtAddress";
            this.mttxtAddress.Size = new System.Drawing.Size(196, 64);
            this.mttxtAddress.TabIndex = 11;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 236);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Address";
            // 
            // mttxtPass
            // 
            this.mttxtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TKbindingSource, "userpassword", true));
            this.mttxtPass.Location = new System.Drawing.Point(184, 106);
            this.mttxtPass.Name = "mttxtPass";
            this.mttxtPass.Size = new System.Drawing.Size(196, 23);
            this.mttxtPass.TabIndex = 13;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Password : ";
            // 
            // mttxtUserName
            // 
            this.mttxtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TKbindingSource, "username", true));
            this.mttxtUserName.Location = new System.Drawing.Point(184, 67);
            this.mttxtUserName.Name = "mttxtUserName";
            this.mttxtUserName.Size = new System.Drawing.Size(196, 23);
            this.mttxtUserName.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "UserName : ";
            // 
            // Form1
            // 
            this.AcceptButton = this.mtbtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 417);
            this.Controls.Add(this.mtbtnSave);
            this.Controls.Add(this.mttxtName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mttxtAddress);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mttxtPass);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mttxtUserName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TKbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton mtbtnSave;
        private MetroFramework.Controls.MetroTextBox mttxtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mttxtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mttxtPass;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mttxtUserName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource TKbindingSource;
    }
}