
namespace BloodDonation
{
    partial class DonationHistory
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
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.AllowUserToAddRows = false;
            this.dtgvHistory.AllowUserToDeleteRows = false;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.details,
            this.bloodGroup,
            this.donorId,
            this.adminId,
            this.date});
            this.dtgvHistory.Enabled = false;
            this.dtgvHistory.Location = new System.Drawing.Point(12, 64);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.Size = new System.Drawing.Size(776, 314);
            this.dtgvHistory.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(256, 24);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(338, 37);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "DONATION HISTORY";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBack.Location = new System.Drawing.Point(665, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Donation ID";
            this.id.Name = "id";
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.details.DataPropertyName = "details";
            this.details.HeaderText = "Donation Details";
            this.details.Name = "details";
            // 
            // bloodGroup
            // 
            this.bloodGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodGroup.DataPropertyName = "bloodGroup";
            this.bloodGroup.HeaderText = "Blood Type";
            this.bloodGroup.Name = "bloodGroup";
            // 
            // donorId
            // 
            this.donorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donorId.DataPropertyName = "donorId";
            this.donorId.HeaderText = "Donor ID";
            this.donorId.Name = "donorId";
            // 
            // adminId
            // 
            this.adminId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adminId.DataPropertyName = "adminId";
            this.adminId.HeaderText = "Admin ID";
            this.adminId.Name = "adminId";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date of Donation";
            this.date.Name = "date";
            // 
            // DonationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dtgvHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DonationHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonationHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHistory;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}