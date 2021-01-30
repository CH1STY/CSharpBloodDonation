
namespace BloodDonation
{
    partial class AddDonor
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
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMobileError = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioSexOther = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblSexError = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDobError = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioTypeAB = new System.Windows.Forms.RadioButton();
            this.radioTypeO = new System.Windows.Forms.RadioButton();
            this.radioTypeB = new System.Windows.Forms.RadioButton();
            this.radioTypeA = new System.Windows.Forms.RadioButton();
            this.lblBloodGroupError = new System.Windows.Forms.Label();
            this.lblRh = new System.Windows.Forms.Label();
            this.lblRhError = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioNegative = new System.Windows.Forms.RadioButton();
            this.radioPositive = new System.Windows.Forms.RadioButton();
            this.lblLastDateError = new System.Windows.Forms.Label();
            this.lblLastDonationDate = new System.Windows.Forms.Label();
            this.dtpLDD = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(295, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(250, 25);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "DONOR REGISTRATION";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(567, 52);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(51, 20);
            this.lblNameError.TabIndex = 12;
            this.lblNameError.Text = "label2";
            this.lblNameError.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(229, 52);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 20);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(296, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 29);
            this.txtName.TabIndex = 10;
            // 
            // lblMobileError
            // 
            this.lblMobileError.AutoSize = true;
            this.lblMobileError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileError.ForeColor = System.Drawing.Color.Red;
            this.lblMobileError.Location = new System.Drawing.Point(567, 87);
            this.lblMobileError.Name = "lblMobileError";
            this.lblMobileError.Size = new System.Drawing.Size(51, 20);
            this.lblMobileError.TabIndex = 15;
            this.lblMobileError.Text = "label2";
            this.lblMobileError.Visible = false;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(225, 87);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(59, 20);
            this.lblMobile.TabIndex = 14;
            this.lblMobile.Text = "Mobile:";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(296, 81);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(248, 29);
            this.txtMobile.TabIndex = 13;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(244, 124);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(40, 20);
            this.lblSex.TabIndex = 16;
            this.lblSex.Text = "Sex:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioSexOther);
            this.panel1.Controls.Add(this.radioFemale);
            this.panel1.Controls.Add(this.radioMale);
            this.panel1.Location = new System.Drawing.Point(296, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 20);
            this.panel1.TabIndex = 17;
            // 
            // radioSexOther
            // 
            this.radioSexOther.AutoSize = true;
            this.radioSexOther.Location = new System.Drawing.Point(158, 2);
            this.radioSexOther.Name = "radioSexOther";
            this.radioSexOther.Size = new System.Drawing.Size(56, 17);
            this.radioSexOther.TabIndex = 2;
            this.radioSexOther.TabStop = true;
            this.radioSexOther.Text = "Others";
            this.radioSexOther.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(79, 2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 1;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(13, 2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // lblSexError
            // 
            this.lblSexError.AutoSize = true;
            this.lblSexError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexError.ForeColor = System.Drawing.Color.Red;
            this.lblSexError.Location = new System.Drawing.Point(567, 127);
            this.lblSexError.Name = "lblSexError";
            this.lblSexError.Size = new System.Drawing.Size(51, 20);
            this.lblSexError.TabIndex = 18;
            this.lblSexError.Text = "label2";
            this.lblSexError.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(212, 161);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(296, 155);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(248, 29);
            this.txtAddress.TabIndex = 20;
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(567, 161);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(51, 20);
            this.lblAddressError.TabIndex = 21;
            this.lblAddressError.Text = "label2";
            this.lblAddressError.Visible = false;
            // 
            // dtpDob
            // 
            this.dtpDob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Location = new System.Drawing.Point(296, 206);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(248, 20);
            this.dtpDob.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Date of Birth:";
            // 
            // lblDobError
            // 
            this.lblDobError.AutoSize = true;
            this.lblDobError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobError.ForeColor = System.Drawing.Color.Red;
            this.lblDobError.Location = new System.Drawing.Point(567, 207);
            this.lblDobError.Name = "lblDobError";
            this.lblDobError.Size = new System.Drawing.Size(51, 20);
            this.lblDobError.TabIndex = 24;
            this.lblDobError.Text = "label2";
            this.lblDobError.Visible = false;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.Location = new System.Drawing.Point(181, 252);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(103, 20);
            this.lblBloodGroup.TabIndex = 25;
            this.lblBloodGroup.Text = "Blood Group:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioTypeAB);
            this.panel2.Controls.Add(this.radioTypeO);
            this.panel2.Controls.Add(this.radioTypeB);
            this.panel2.Controls.Add(this.radioTypeA);
            this.panel2.Location = new System.Drawing.Point(296, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 19);
            this.panel2.TabIndex = 26;
            // 
            // radioTypeAB
            // 
            this.radioTypeAB.AutoSize = true;
            this.radioTypeAB.Location = new System.Drawing.Point(118, 1);
            this.radioTypeAB.Name = "radioTypeAB";
            this.radioTypeAB.Size = new System.Drawing.Size(39, 17);
            this.radioTypeAB.TabIndex = 3;
            this.radioTypeAB.TabStop = true;
            this.radioTypeAB.Text = "AB";
            this.radioTypeAB.UseVisualStyleBackColor = true;
            // 
            // radioTypeO
            // 
            this.radioTypeO.AutoSize = true;
            this.radioTypeO.Location = new System.Drawing.Point(79, 1);
            this.radioTypeO.Name = "radioTypeO";
            this.radioTypeO.Size = new System.Drawing.Size(33, 17);
            this.radioTypeO.TabIndex = 2;
            this.radioTypeO.TabStop = true;
            this.radioTypeO.Text = "O";
            this.radioTypeO.UseVisualStyleBackColor = true;
            // 
            // radioTypeB
            // 
            this.radioTypeB.AutoSize = true;
            this.radioTypeB.Location = new System.Drawing.Point(42, 1);
            this.radioTypeB.Name = "radioTypeB";
            this.radioTypeB.Size = new System.Drawing.Size(32, 17);
            this.radioTypeB.TabIndex = 1;
            this.radioTypeB.TabStop = true;
            this.radioTypeB.Text = "B";
            this.radioTypeB.UseVisualStyleBackColor = true;
            // 
            // radioTypeA
            // 
            this.radioTypeA.AutoSize = true;
            this.radioTypeA.Location = new System.Drawing.Point(4, 1);
            this.radioTypeA.Name = "radioTypeA";
            this.radioTypeA.Size = new System.Drawing.Size(32, 17);
            this.radioTypeA.TabIndex = 0;
            this.radioTypeA.TabStop = true;
            this.radioTypeA.Text = "A";
            this.radioTypeA.UseVisualStyleBackColor = true;
            // 
            // lblBloodGroupError
            // 
            this.lblBloodGroupError.AutoSize = true;
            this.lblBloodGroupError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroupError.ForeColor = System.Drawing.Color.Red;
            this.lblBloodGroupError.Location = new System.Drawing.Point(567, 250);
            this.lblBloodGroupError.Name = "lblBloodGroupError";
            this.lblBloodGroupError.Size = new System.Drawing.Size(51, 20);
            this.lblBloodGroupError.TabIndex = 27;
            this.lblBloodGroupError.Text = "label2";
            this.lblBloodGroupError.Visible = false;
            // 
            // lblRh
            // 
            this.lblRh.AutoSize = true;
            this.lblRh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRh.Location = new System.Drawing.Point(250, 286);
            this.lblRh.Name = "lblRh";
            this.lblRh.Size = new System.Drawing.Size(34, 20);
            this.lblRh.TabIndex = 28;
            this.lblRh.Text = "Rh:";
            // 
            // lblRhError
            // 
            this.lblRhError.AutoSize = true;
            this.lblRhError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRhError.ForeColor = System.Drawing.Color.Red;
            this.lblRhError.Location = new System.Drawing.Point(567, 286);
            this.lblRhError.Name = "lblRhError";
            this.lblRhError.Size = new System.Drawing.Size(51, 20);
            this.lblRhError.TabIndex = 29;
            this.lblRhError.Text = "label2";
            this.lblRhError.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioNegative);
            this.panel3.Controls.Add(this.radioPositive);
            this.panel3.Location = new System.Drawing.Point(296, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 20);
            this.panel3.TabIndex = 30;
            // 
            // radioNegative
            // 
            this.radioNegative.AutoSize = true;
            this.radioNegative.Location = new System.Drawing.Point(99, 2);
            this.radioNegative.Name = "radioNegative";
            this.radioNegative.Size = new System.Drawing.Size(68, 17);
            this.radioNegative.TabIndex = 4;
            this.radioNegative.TabStop = true;
            this.radioNegative.Text = "Negative";
            this.radioNegative.UseVisualStyleBackColor = true;
            // 
            // radioPositive
            // 
            this.radioPositive.AutoSize = true;
            this.radioPositive.Location = new System.Drawing.Point(3, 2);
            this.radioPositive.Name = "radioPositive";
            this.radioPositive.Size = new System.Drawing.Size(62, 17);
            this.radioPositive.TabIndex = 4;
            this.radioPositive.TabStop = true;
            this.radioPositive.Text = "Positive";
            this.radioPositive.UseVisualStyleBackColor = true;
            // 
            // lblLastDateError
            // 
            this.lblLastDateError.AutoSize = true;
            this.lblLastDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastDateError.ForeColor = System.Drawing.Color.Red;
            this.lblLastDateError.Location = new System.Drawing.Point(567, 333);
            this.lblLastDateError.Name = "lblLastDateError";
            this.lblLastDateError.Size = new System.Drawing.Size(51, 20);
            this.lblLastDateError.TabIndex = 33;
            this.lblLastDateError.Text = "label2";
            this.lblLastDateError.Visible = false;
            // 
            // lblLastDonationDate
            // 
            this.lblLastDonationDate.AutoSize = true;
            this.lblLastDonationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastDonationDate.Location = new System.Drawing.Point(174, 332);
            this.lblLastDonationDate.Name = "lblLastDonationDate";
            this.lblLastDonationDate.Size = new System.Drawing.Size(110, 20);
            this.lblLastDonationDate.TabIndex = 32;
            this.lblLastDonationDate.Text = "Last Donated:";
            // 
            // dtpLDD
            // 
            this.dtpLDD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLDD.Location = new System.Drawing.Point(296, 332);
            this.dtpLDD.Name = "dtpLDD";
            this.dtpLDD.Size = new System.Drawing.Size(248, 20);
            this.dtpLDD.TabIndex = 31;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(338, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 46);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(327, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 46);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "ADD DONOR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 477);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblLastDateError);
            this.Controls.Add(this.lblLastDonationDate);
            this.Controls.Add(this.dtpLDD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblRhError);
            this.Controls.Add(this.lblRh);
            this.Controls.Add(this.lblBloodGroupError);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.lblDobError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSexError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblMobileError);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDonor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMobileError;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioSexOther;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label lblSexError;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDobError;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioTypeAB;
        private System.Windows.Forms.RadioButton radioTypeO;
        private System.Windows.Forms.RadioButton radioTypeB;
        private System.Windows.Forms.RadioButton radioTypeA;
        private System.Windows.Forms.Label lblBloodGroupError;
        private System.Windows.Forms.Label lblRh;
        private System.Windows.Forms.Label lblRhError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioNegative;
        private System.Windows.Forms.RadioButton radioPositive;
        private System.Windows.Forms.Label lblLastDateError;
        private System.Windows.Forms.Label lblLastDonationDate;
        private System.Windows.Forms.DateTimePicker dtpLDD;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
    }
}