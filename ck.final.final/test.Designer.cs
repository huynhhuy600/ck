namespace ck.final.final
{
    partial class test
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtbtnSave = new MetroFramework.Controls.MetroButton();
            this.mttxtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mttxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mttxtConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.mttxtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mttxtUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bindingSourceTK = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTK)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.White;
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(27, 333);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(47, 32);
            this.metroTile1.TabIndex = 16;
            this.metroTile1.TileImage = global::ck.final.final.Properties.Resources.iconfinder_Undo_27885__2_;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            // 
            // mtbtnSave
            // 
            this.mtbtnSave.Location = new System.Drawing.Point(176, 333);
            this.mtbtnSave.Name = "mtbtnSave";
            this.mtbtnSave.Size = new System.Drawing.Size(75, 23);
            this.mtbtnSave.TabIndex = 15;
            this.mtbtnSave.Text = "Save";
            this.mtbtnSave.Click += new System.EventHandler(this.MtbtnSave_Click);
            // 
            // mttxtName
            // 
            this.mttxtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceTK, "name", true));
            this.mttxtName.Location = new System.Drawing.Point(176, 191);
            this.mttxtName.Name = "mttxtName";
            this.mttxtName.Size = new System.Drawing.Size(196, 23);
            this.mttxtName.TabIndex = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(33, 195);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Name : ";
            // 
            // mttxtAddress
            // 
            this.mttxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceTK, "address", true));
            this.mttxtAddress.Location = new System.Drawing.Point(176, 240);
            this.mttxtAddress.Multiline = true;
            this.mttxtAddress.Name = "mttxtAddress";
            this.mttxtAddress.Size = new System.Drawing.Size(196, 64);
            this.mttxtAddress.TabIndex = 11;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 240);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Address";
            // 
            // mttxtConfirmPass
            // 
            this.mttxtConfirmPass.Location = new System.Drawing.Point(176, 143);
            this.mttxtConfirmPass.Name = "mttxtConfirmPass";
            this.mttxtConfirmPass.Size = new System.Drawing.Size(196, 23);
            this.mttxtConfirmPass.TabIndex = 12;
            // 
            // mttxtPass
            // 
            this.mttxtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceTK, "userpassword", true));
            this.mttxtPass.Location = new System.Drawing.Point(176, 110);
            this.mttxtPass.Name = "mttxtPass";
            this.mttxtPass.Size = new System.Drawing.Size(196, 23);
            this.mttxtPass.TabIndex = 13;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 147);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "ConfirmPass";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Password : ";
            // 
            // mttxtUserName
            // 
            this.mttxtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceTK, "username", true));
            this.mttxtUserName.Location = new System.Drawing.Point(176, 71);
            this.mttxtUserName.Name = "mttxtUserName";
            this.mttxtUserName.Size = new System.Drawing.Size(196, 23);
            this.mttxtUserName.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "UserName : ";
            // 
            // bindingSourceTK
            // 
            this.bindingSourceTK.DataSource = typeof(ck.final.final.taikhoan);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 426);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mtbtnSave);
            this.Controls.Add(this.mttxtName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mttxtAddress);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mttxtConfirmPass);
            this.Controls.Add(this.mttxtPass);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mttxtUserName);
            this.Controls.Add(this.metroLabel1);
            this.Name = "test";
            this.Text = "test";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton mtbtnSave;
        private MetroFramework.Controls.MetroTextBox mttxtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mttxtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mttxtConfirmPass;
        private MetroFramework.Controls.MetroTextBox mttxtPass;
        private System.Windows.Forms.BindingSource bindingSourceTK;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mttxtUserName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}