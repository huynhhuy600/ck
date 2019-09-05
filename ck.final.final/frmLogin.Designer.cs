namespace ck.final.final
{
    partial class frmLogin
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
            this.mtUsername = new MetroFramework.Controls.MetroTile();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.mtPass = new MetroFramework.Controls.MetroTile();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.mtbtnResiger = new MetroFramework.Controls.MetroButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taikhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mtUsername
            // 
            this.mtUsername.Location = new System.Drawing.Point(41, 95);
            this.mtUsername.Name = "mtUsername";
            this.mtUsername.Size = new System.Drawing.Size(85, 23);
            this.mtUsername.TabIndex = 1;
            this.mtUsername.Text = "Username :";
            this.mtUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 23);
            this.txtName.TabIndex = 0;
            // 
            // mtPass
            // 
            this.mtPass.Location = new System.Drawing.Point(41, 152);
            this.mtPass.Name = "mtPass";
            this.mtPass.Size = new System.Drawing.Size(85, 23);
            this.mtPass.TabIndex = 1;
            this.mtPass.Text = "Password : ";
            this.mtPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(165, 152);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(168, 23);
            this.txtPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(68, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Login";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // mtbtnResiger
            // 
            this.mtbtnResiger.Location = new System.Drawing.Point(220, 230);
            this.mtbtnResiger.Name = "mtbtnResiger";
            this.mtbtnResiger.Size = new System.Drawing.Size(75, 23);
            this.mtbtnResiger.TabIndex = 3;
            this.mtbtnResiger.Text = "&Resiger";
            this.mtbtnResiger.Click += new System.EventHandler(this.MtbtnResiger_Click);
            // 
            // taikhoanBindingSource
            // 
            this.taikhoanBindingSource.DataSource = typeof(ck.final.final.taikhoan);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(35, 192);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 318);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.mtbtnResiger);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.mtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mtUsername);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtUsername;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTile mtPass;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroButton mtbtnResiger;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource taikhoanBindingSource;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}