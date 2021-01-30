
namespace BloodDonation
{
    partial class AdminReg
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorMobile = new System.Windows.Forms.Label();
            this.lblCfmPasswordError = new System.Windows.Forms.Label();
            this.lblCfmPassword = new System.Windows.Forms.Label();
            this.txtCfmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(271, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(240, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ADMIN REGISTRATION";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(263, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(263, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(263, 206);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(248, 29);
            this.txtMobile.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(192, 53);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Name:";
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPass.Location = new System.Drawing.Point(169, 108);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(82, 20);
            this.lblUserPass.TabIndex = 5;
            this.lblUserPass.Text = "Password:";
            this.lblUserPass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(192, 212);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(59, 20);
            this.lblMobile.TabIndex = 6;
            this.lblMobile.Text = "Mobile:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(309, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "REGISTER";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(309, 293);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(534, 53);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(51, 20);
            this.lblErrorName.TabIndex = 9;
            this.lblErrorName.Text = "label2";
            this.lblErrorName.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(534, 113);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(51, 20);
            this.lblErrorPassword.TabIndex = 10;
            this.lblErrorPassword.Text = "label3";
            this.lblErrorPassword.Visible = false;
            // 
            // lblErrorMobile
            // 
            this.lblErrorMobile.AutoSize = true;
            this.lblErrorMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMobile.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMobile.Location = new System.Drawing.Point(534, 212);
            this.lblErrorMobile.Name = "lblErrorMobile";
            this.lblErrorMobile.Size = new System.Drawing.Size(51, 20);
            this.lblErrorMobile.TabIndex = 11;
            this.lblErrorMobile.Text = "label4";
            this.lblErrorMobile.Visible = false;
            // 
            // lblCfmPasswordError
            // 
            this.lblCfmPasswordError.AutoSize = true;
            this.lblCfmPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblCfmPasswordError.Location = new System.Drawing.Point(534, 163);
            this.lblCfmPasswordError.Name = "lblCfmPasswordError";
            this.lblCfmPasswordError.Size = new System.Drawing.Size(51, 20);
            this.lblCfmPasswordError.TabIndex = 14;
            this.lblCfmPasswordError.Text = "label3";
            this.lblCfmPasswordError.Visible = false;
            // 
            // lblCfmPassword
            // 
            this.lblCfmPassword.AutoSize = true;
            this.lblCfmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfmPassword.Location = new System.Drawing.Point(106, 164);
            this.lblCfmPassword.Name = "lblCfmPassword";
            this.lblCfmPassword.Size = new System.Drawing.Size(141, 20);
            this.lblCfmPassword.TabIndex = 13;
            this.lblCfmPassword.Text = "Confirm Password:";
            this.lblCfmPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCfmPassword
            // 
            this.txtCfmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCfmPassword.Location = new System.Drawing.Point(263, 158);
            this.txtCfmPassword.Name = "txtCfmPassword";
            this.txtCfmPassword.Size = new System.Drawing.Size(248, 29);
            this.txtCfmPassword.TabIndex = 3;
            this.txtCfmPassword.UseSystemPasswordChar = true;
            // 
            // AdminReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 356);
            this.Controls.Add(this.lblCfmPasswordError);
            this.Controls.Add(this.lblCfmPassword);
            this.Controls.Add(this.txtCfmPassword);
            this.Controls.Add(this.lblErrorMobile);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblUserPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorMobile;
        private System.Windows.Forms.Label lblCfmPasswordError;
        private System.Windows.Forms.Label lblCfmPassword;
        private System.Windows.Forms.TextBox txtCfmPassword;
    }
}