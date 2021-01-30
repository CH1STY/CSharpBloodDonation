
namespace BloodDonation
{
    partial class AddDonation
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDonationDate = new System.Windows.Forms.DateTimePicker();
            this.lblPatDet = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioNegative = new System.Windows.Forms.RadioButton();
            this.radioPositive = new System.Windows.Forms.RadioButton();
            this.lblRh = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioTypeAB = new System.Windows.Forms.RadioButton();
            this.radioTypeO = new System.Windows.Forms.RadioButton();
            this.radioTypeB = new System.Windows.Forms.RadioButton();
            this.radioTypeA = new System.Windows.Forms.RadioButton();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.comboDonorList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblBloodGroupError = new System.Windows.Forms.Label();
            this.lblRhError = new System.Windows.Forms.Label();
            this.lblDonorError = new System.Windows.Forms.Label();
            this.lblDetailsError = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(244, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(286, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "DONATION PAGE";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(616, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 51);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(96, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 24);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Select Date:";
            // 
            // dtpDonationDate
            // 
            this.dtpDonationDate.Location = new System.Drawing.Point(251, 98);
            this.dtpDonationDate.Name = "dtpDonationDate";
            this.dtpDonationDate.Size = new System.Drawing.Size(199, 20);
            this.dtpDonationDate.TabIndex = 7;
            // 
            // lblPatDet
            // 
            this.lblPatDet.AutoSize = true;
            this.lblPatDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatDet.Location = new System.Drawing.Point(6, 251);
            this.lblPatDet.Name = "lblPatDet";
            this.lblPatDet.Size = new System.Drawing.Size(200, 24);
            this.lblPatDet.TabIndex = 8;
            this.lblPatDet.Text = "Enter Donation Details:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioNegative);
            this.panel3.Controls.Add(this.radioPositive);
            this.panel3.Location = new System.Drawing.Point(251, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 20);
            this.panel3.TabIndex = 34;
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
            this.radioNegative.Click += new System.EventHandler(this.radioNegative_Click);
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
            this.radioPositive.Click += new System.EventHandler(this.radioPositive_Click);
            // 
            // lblRh
            // 
            this.lblRh.AutoSize = true;
            this.lblRh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRh.Location = new System.Drawing.Point(167, 162);
            this.lblRh.Name = "lblRh";
            this.lblRh.Size = new System.Drawing.Size(39, 24);
            this.lblRh.TabIndex = 33;
            this.lblRh.Text = "Rh:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioTypeAB);
            this.panel2.Controls.Add(this.radioTypeO);
            this.panel2.Controls.Add(this.radioTypeB);
            this.panel2.Controls.Add(this.radioTypeA);
            this.panel2.Location = new System.Drawing.Point(251, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 19);
            this.panel2.TabIndex = 32;
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
            this.radioTypeAB.Click += new System.EventHandler(this.radioTypeA_Click);
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
            this.radioTypeO.Click += new System.EventHandler(this.radioTypeA_Click);
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
            this.radioTypeB.Click += new System.EventHandler(this.radioTypeA_Click);
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
            this.radioTypeA.Click += new System.EventHandler(this.radioTypeA_Click);
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.Location = new System.Drawing.Point(84, 129);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(122, 24);
            this.lblBloodGroup.TabIndex = 31;
            this.lblBloodGroup.Text = "Blood Group:";
            // 
            // comboDonorList
            // 
            this.comboDonorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDonorList.Enabled = false;
            this.comboDonorList.FormattingEnabled = true;
            this.comboDonorList.Location = new System.Drawing.Point(251, 211);
            this.comboDonorList.Name = "comboDonorList";
            this.comboDonorList.Size = new System.Drawing.Size(248, 21);
            this.comboDonorList.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Donor:";
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(523, 97);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(51, 20);
            this.lblDateError.TabIndex = 37;
            this.lblDateError.Text = "label2";
            this.lblDateError.Visible = false;
            // 
            // lblBloodGroupError
            // 
            this.lblBloodGroupError.AutoSize = true;
            this.lblBloodGroupError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroupError.ForeColor = System.Drawing.Color.Red;
            this.lblBloodGroupError.Location = new System.Drawing.Point(523, 135);
            this.lblBloodGroupError.Name = "lblBloodGroupError";
            this.lblBloodGroupError.Size = new System.Drawing.Size(51, 20);
            this.lblBloodGroupError.TabIndex = 38;
            this.lblBloodGroupError.Text = "label2";
            this.lblBloodGroupError.Visible = false;
            // 
            // lblRhError
            // 
            this.lblRhError.AutoSize = true;
            this.lblRhError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRhError.ForeColor = System.Drawing.Color.Red;
            this.lblRhError.Location = new System.Drawing.Point(523, 165);
            this.lblRhError.Name = "lblRhError";
            this.lblRhError.Size = new System.Drawing.Size(51, 20);
            this.lblRhError.TabIndex = 39;
            this.lblRhError.Text = "label2";
            this.lblRhError.Visible = false;
            // 
            // lblDonorError
            // 
            this.lblDonorError.AutoSize = true;
            this.lblDonorError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorError.ForeColor = System.Drawing.Color.Red;
            this.lblDonorError.Location = new System.Drawing.Point(523, 210);
            this.lblDonorError.Name = "lblDonorError";
            this.lblDonorError.Size = new System.Drawing.Size(51, 20);
            this.lblDonorError.TabIndex = 40;
            this.lblDonorError.Text = "label2";
            this.lblDonorError.Visible = false;
            // 
            // lblDetailsError
            // 
            this.lblDetailsError.AutoSize = true;
            this.lblDetailsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsError.ForeColor = System.Drawing.Color.Red;
            this.lblDetailsError.Location = new System.Drawing.Point(523, 281);
            this.lblDetailsError.Name = "lblDetailsError";
            this.lblDetailsError.Size = new System.Drawing.Size(51, 20);
            this.lblDetailsError.TabIndex = 41;
            this.lblDetailsError.Text = "label2";
            this.lblDetailsError.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirm.Location = new System.Drawing.Point(306, 349);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(123, 51);
            this.btnConfirm.TabIndex = 42;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetails.Location = new System.Drawing.Point(251, 256);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(248, 70);
            this.txtDetails.TabIndex = 9;
            this.txtDetails.Text = "";
            // 
            // AddDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblDetailsError);
            this.Controls.Add(this.lblDonorError);
            this.Controls.Add(this.lblRhError);
            this.Controls.Add(this.lblBloodGroupError);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDonorList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblRh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblPatDet);
            this.Controls.Add(this.dtpDonationDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddDonation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDonation";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDonationDate;
        private System.Windows.Forms.Label lblPatDet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioNegative;
        private System.Windows.Forms.RadioButton radioPositive;
        private System.Windows.Forms.Label lblRh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioTypeAB;
        private System.Windows.Forms.RadioButton radioTypeO;
        private System.Windows.Forms.RadioButton radioTypeB;
        private System.Windows.Forms.RadioButton radioTypeA;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox comboDonorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblBloodGroupError;
        private System.Windows.Forms.Label lblRhError;
        private System.Windows.Forms.Label lblDonorError;
        private System.Windows.Forms.Label lblDetailsError;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RichTextBox txtDetails;
    }
}