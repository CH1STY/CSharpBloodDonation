
namespace BloodDonation
{
    partial class DonorList
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bloodDonationMgtDataSet = new BloodDonation.BloodDonationMgtDataSet();
            this.donorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorTableAdapter = new BloodDonation.BloodDonationMgtDataSetTableAdapters.DonorTableAdapter();
            this.dtgvDonorList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDonationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationMgtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonorList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1056, 623);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 46);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(547, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(138, 31);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Donor List";
            // 
            // bloodDonationMgtDataSet
            // 
            this.bloodDonationMgtDataSet.DataSetName = "BloodDonationMgtDataSet";
            this.bloodDonationMgtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorBindingSource
            // 
            this.donorBindingSource.DataMember = "Donor";
            this.donorBindingSource.DataSource = this.bloodDonationMgtDataSet;
            // 
            // donorTableAdapter
            // 
            this.donorTableAdapter.ClearBeforeFill = true;
            // 
            // dtgvDonorList
            // 
            this.dtgvDonorList.AllowUserToAddRows = false;
            this.dtgvDonorList.AllowUserToDeleteRows = false;
            this.dtgvDonorList.AllowUserToOrderColumns = true;
            this.dtgvDonorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDonorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.mobile,
            this.sex,
            this.bloodGroup,
            this.rh,
            this.dob,
            this.adminId,
            this.lastDonationDate,
            this.detailsBtn});
            this.dtgvDonorList.Location = new System.Drawing.Point(24, 70);
            this.dtgvDonorList.Name = "dtgvDonorList";
            this.dtgvDonorList.Size = new System.Drawing.Size(1178, 547);
            this.dtgvDonorList.TabIndex = 12;
            this.dtgvDonorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDonorList_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // mobile
            // 
            this.mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "Mobile Number";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "Gender";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // bloodGroup
            // 
            this.bloodGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodGroup.DataPropertyName = "bloodGroup";
            this.bloodGroup.HeaderText = "Blood Group";
            this.bloodGroup.Name = "bloodGroup";
            this.bloodGroup.ReadOnly = true;
            // 
            // rh
            // 
            this.rh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rh.DataPropertyName = "rh";
            this.rh.HeaderText = "Rh Type";
            this.rh.Name = "rh";
            this.rh.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Date Of Birth(mm-dd-yyyy)";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // adminId
            // 
            this.adminId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adminId.DataPropertyName = "adminId";
            this.adminId.HeaderText = "Admin Id";
            this.adminId.Name = "adminId";
            this.adminId.ReadOnly = true;
            // 
            // lastDonationDate
            // 
            this.lastDonationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastDonationDate.DataPropertyName = "lastDonationDate";
            this.lastDonationDate.HeaderText = "Last Donated (mm-dd-yyyy)";
            this.lastDonationDate.Name = "lastDonationDate";
            this.lastDonationDate.ReadOnly = true;
            // 
            // detailsBtn
            // 
            this.detailsBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detailsBtn.HeaderText = "Action";
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Text = "View History";
            this.detailsBtn.UseColumnTextForButtonValue = true;
            // 
            // DonorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 681);
            this.Controls.Add(this.dtgvDonorList);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DonorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonorList";
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonationMgtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeader;
        private BloodDonationMgtDataSet bloodDonationMgtDataSet;
        private System.Windows.Forms.BindingSource donorBindingSource;
        private BloodDonationMgtDataSetTableAdapters.DonorTableAdapter donorTableAdapter;
        private System.Windows.Forms.DataGridView dtgvDonorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn rh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDonationDate;
        private System.Windows.Forms.DataGridViewButtonColumn detailsBtn;
    }
}