
namespace BloodDonation
{
    partial class DonarDetails
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblLastDonation = new System.Windows.Forms.Label();
            this.lblDonationHistoryHeader = new System.Windows.Forms.Label();
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            this.lblAge = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(253, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(275, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Donor Information";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(647, 531);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 46);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(12, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMobile.Location = new System.Drawing.Point(555, 63);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(38, 13);
            this.lblMobile.TabIndex = 12;
            this.lblMobile.Text = "Name:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSex.Location = new System.Drawing.Point(12, 97);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(38, 13);
            this.lblSex.TabIndex = 13;
            this.lblSex.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAddress.Location = new System.Drawing.Point(555, 97);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Name:";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBloodType.Location = new System.Drawing.Point(12, 133);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(38, 13);
            this.lblBloodType.TabIndex = 15;
            this.lblBloodType.Text = "Name:";
            // 
            // lblLastDonation
            // 
            this.lblLastDonation.AutoSize = true;
            this.lblLastDonation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLastDonation.Location = new System.Drawing.Point(555, 133);
            this.lblLastDonation.Name = "lblLastDonation";
            this.lblLastDonation.Size = new System.Drawing.Size(38, 13);
            this.lblLastDonation.TabIndex = 16;
            this.lblLastDonation.Text = "Name:";
            // 
            // lblDonationHistoryHeader
            // 
            this.lblDonationHistoryHeader.AutoSize = true;
            this.lblDonationHistoryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonationHistoryHeader.Location = new System.Drawing.Point(298, 178);
            this.lblDonationHistoryHeader.Name = "lblDonationHistoryHeader";
            this.lblDonationHistoryHeader.Size = new System.Drawing.Size(171, 25);
            this.lblDonationHistoryHeader.TabIndex = 17;
            this.lblDonationHistoryHeader.Text = "Donation History";
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.AllowUserToAddRows = false;
            this.dtgvHistory.AllowUserToDeleteRows = false;
            this.dtgvHistory.AllowUserToOrderColumns = true;
            this.dtgvHistory.AllowUserToResizeColumns = false;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.details});
            this.dtgvHistory.Enabled = false;
            this.dtgvHistory.Location = new System.Drawing.Point(15, 224);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.Size = new System.Drawing.Size(778, 301);
            this.dtgvHistory.TabIndex = 18;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAge.Location = new System.Drawing.Point(12, 161);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 13);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Name:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.details.DataPropertyName = "details";
            this.details.HeaderText = "Details";
            this.details.Name = "details";
            // 
            // DonarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 589);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dtgvHistory);
            this.Controls.Add(this.lblDonationHistoryHeader);
            this.Controls.Add(this.lblLastDonation);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);
            this.MaximizeBox = false;
            this.Name = "DonarDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonarDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblLastDonation;
        private System.Windows.Forms.Label lblDonationHistoryHeader;
        private System.Windows.Forms.DataGridView dtgvHistory;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
    }
}