using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodDonation.Entity;

namespace BloodDonation
{
    public partial class AddDonation : Form
    {
        Admin admin;
        bool noDonor = false;
        public AddDonation(Admin adObj)
        {
            InitializeComponent();

            this.admin = adObj;
            


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new AdminPanel(admin);
            newForm.ShowDialog();
            this.Dispose();
        }

        private void radioNegative_Click(object sender, EventArgs e)
        {
            NameFunc();
        }
        private void radioPositive_Click(object sender, EventArgs e)
        {
            NameFunc();
        }

        private void radioTypeA_Click(object sender, EventArgs e)
        {
            NameFunc();
        }

        private void NameFunc()
        {
            bool groupFlag = false;
            bool rhFlag = false;

            if(!radioTypeA.Checked && !radioTypeB.Checked && !radioTypeO.Checked && !radioTypeAB.Checked)
            {
                groupFlag = true;
            }

            if(!radioPositive.Checked && !radioNegative.Checked)
            {
                rhFlag = true;
            }


            if(!groupFlag && !rhFlag)
            {
                
                PopulateComboList();
            }
            else
            {
                this.comboDonorList.Enabled = false;

            }


        }

        private void PopulateComboList()
        {

            string bloodGroup, rh;

            if (radioTypeA.Checked)
            {
                bloodGroup = "A";
            }
            else if (radioTypeB.Checked)
            {
                bloodGroup = "B";
            }
            else if (radioTypeO.Checked)
            {
                bloodGroup = "O";
            }
            else
            {
                bloodGroup = "AB";
            }

            if (radioPositive.Checked)
            {
                rh = "Positive";
            }
            else
            {
                rh = "Negative";
            }

            var dt = Blood.getDonorNameList(bloodGroup, rh);
            Dictionary<string, string> combosource = new Dictionary<string, string>();
            if (dt.Rows.Count>0) { 

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    combosource.Add(dt.Rows[i]["id"].ToString(), dt.Rows[i]["name"].ToString());
                }

            this.comboDonorList.DataSource = new BindingSource(combosource, null);
            this.comboDonorList.DisplayMember = "Value";
            this.comboDonorList.ValueMember = "Key";
            this.comboDonorList.Enabled = true;
            this.noDonor = false;
            this.lblDonorError.Visible = false;
            }
            else
            {
                this.noDonor = true;
                this.lblDonorError.Text = "No Available Donor";
                this.comboDonorList.DataSource = null;
                this.comboDonorList.Enabled = false;
                this.lblDonorError.Visible = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if(dtpDonationDate.Value> DateTime.Now)
            {
                flag = true;
                lblDateError.Text = "Date can't be in Future";
                lblDateError.Visible = true;
            }
            else
            {
                lblDateError.Visible = false;
            }

            if (!radioTypeA.Checked && !radioTypeB.Checked && !radioTypeO.Checked && !radioTypeAB.Checked)
            {
                flag = true;
                lblBloodGroupError.Text = "Select a Blood Group";
                lblBloodGroupError.Visible = true;
            }
            else
            {
                lblBloodGroupError.Visible = false;

            }

            if (!radioPositive.Checked && !radioNegative.Checked)
            {
                flag = true;
                lblRhError.Text = "Select Blood Group Type";
                lblRhError.Visible = true;
            }else
            {
                lblRhError.Visible = false;
            }

            if(this.comboDonorList.SelectedItem== null)
            {
                flag = true;
                if (!noDonor)
                {
                    lblDonorError.Text = "Select a Donor";
                }
                lblDonorError.Visible = true;
            }
            else
            {
                if (!noDonor)
                {
                    lblDonorError.Visible = false;
                }
            }

            if(String.IsNullOrEmpty(this.txtDetails.Text))
            {
                flag = true;
                this.lblDetailsError.Text = "Record Must Contain Details";
                this.lblDetailsError.Visible = true;
            }
            else
            {
                lblDetailsError.Visible = false;
            }

            if(!flag)
            {
                string id, date, details,bloodGroup, donorId, adminId;
               
                id = Blood.GetDonationId();

                date = this.dtpDonationDate.Value.ToString();

                int indexOfSpace = date.IndexOf(" ");

                date = date.Substring(0, indexOfSpace);

                if (radioTypeA.Checked)
                {
                    bloodGroup = "A";
                }
                else if (radioTypeB.Checked)
                {
                    bloodGroup = "B";
                }
                else if (radioTypeO.Checked)
                {
                    bloodGroup = "O";
                }
                else
                {
                    bloodGroup = "AB";
                }

                if (radioPositive.Checked)
                {
                    bloodGroup += "+";
                }
                else
                {
                    bloodGroup += "-";
                }

                donorId = comboDonorList.SelectedValue.ToString();

                donorId = donorId.Substring(0, 4);

                adminId = this.admin.Id;

                details = txtDetails.Text;


                Blood.InsertDonationRecord(id, date, details, bloodGroup, donorId, adminId);

                MessageBox.Show("Successfully Added Donation to Records Record Id: "+id+"","Success",MessageBoxButtons.OK);

                var newForm = new AdminPanel(admin);
                this.Hide();
                newForm.ShowDialog();
                this.Dispose();
                
            }


        }
    }
}
