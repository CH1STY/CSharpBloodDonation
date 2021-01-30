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
    public partial class AddDonor : Form
    {

        int GetDifferenceInYears(DateTime startDate, DateTime endDate)
        {
            return (endDate.Year - startDate.Year - 1) +
                (((endDate.Month > startDate.Month) ||
                ((endDate.Month == startDate.Month) && (endDate.Day >= startDate.Day))) ? 1 : 0);
        }

        Admin admin;
        public AddDonor(Admin adObj)
        {
            
            InitializeComponent();
            this.admin = adObj;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var newForm = new AdminPanel(admin);
            this.Hide();
            newForm.ShowDialog();
            this.Dispose();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if(String.IsNullOrEmpty(this.txtName.Text))
            {
                flag = true;
                this.lblNameError.Text = "Name can't be Empty";
                this.lblNameError.Visible = true;

            }    
            else
            {
                this.lblNameError.Visible = false;
            }

            if (String.IsNullOrEmpty(this.txtMobile.Text))
            {
                flag = true;
                this.lblMobileError.Text = "Mobile Number can't be Empty";
                this.lblMobileError.Visible = true;


            }
            else
            {
                this.lblMobileError.Visible = false; ;
            }


            if(!this.radioMale.Checked && !this.radioFemale.Checked && !this.radioSexOther.Checked)
            {
                flag = true;
                this.lblSexError.Text = "Please Choose a Sex";
                this.lblSexError.Visible = true;

            }
            else
            {
                this.lblSexError.Visible = false;
            }

            if(String.IsNullOrEmpty(this.txtAddress.Text))
            {
                flag = true;
                this.lblAddressError.Text = "Enter your address";
                this.lblAddressError.Visible = true;
            }
            else
            {
                this.lblAddressError.Visible = false;

            }
            
            var differenceInYear = GetDifferenceInYears(this.dtpDob.Value, DateTime.Today);

            if(differenceInYear<18)
            {
                flag = true;
                this.lblDobError.Text = "Minimum Age requirement is Empty";
                this.lblDobError.Visible = true;
            } 
            else
            {
                this.lblDobError.Visible = false;

            }

            if(!this.radioTypeA.Checked && !this.radioTypeB.Checked && !this.radioTypeO.Checked && !this.radioTypeAB.Checked)
            {
                flag = true;
                this.lblBloodGroupError.Text = "Select a blood group";
                this.lblBloodGroupError.Visible = true;
            }
            else
            {
                this.lblBloodGroupError.Visible = false;

            }

            if(!this.radioPositive.Checked && !this.radioNegative.Checked)
            {
                flag = true;
                this.lblRhError.Text = "Select a Rh Type";
                this.lblRhError.Visible = true;
            }
            else
            {
                this.lblRhError.Visible = false;

            }

            if(this.dtpLDD.Value> DateTime.Now)
            {
                flag = true;
                this.lblLastDateError.Text = "Donation Date can't be in future";
                this.lblLastDateError.Visible = true;
            }
            else
            {
                this.lblLastDateError.Visible = false;

            }

            if (!flag)
            {
                string dateOfBirth = this.dtpDob.Value.Year.ToString()+"-"+ this.dtpDob.Value.Month.ToString()+"-"+ this.dtpDob.Value.Day.ToString();
                string lastDateOfDonation = this.dtpLDD.Value.Year.ToString() + "-" + this.dtpLDD.Value.Month.ToString() + "-" + this.dtpLDD.Value.Day.ToString();
                string name = this.txtName.Text;
                string mobile = this.txtMobile.Text;
                string address = this.txtAddress.Text;
                string sex,bloodGroup,rh;

                if(this.radioMale.Checked)
                {
                    sex = "Male";
                }
                else if(this.radioFemale.Checked)
                {
                    sex = "Female";
                }
                else
                {
                    sex = "Others";
                }

                if(radioTypeA.Checked)
                {
                    bloodGroup = "A";
                }
                else if(radioTypeB.Checked)
                {
                    bloodGroup = "B";
                }
                else if(radioTypeO.Checked)
                {
                    bloodGroup = "O";
                }
                else
                {
                    bloodGroup = "AB";
                }

                if(radioPositive.Checked)
                {
                    rh = "Positive";
                }
                else
                {
                    rh = "Negative";
                }

                Donor.InsertIntoDonor(name, mobile, sex, address, dateOfBirth, bloodGroup, rh, lastDateOfDonation, this.admin.Id);
                MessageBox.Show("DONOR SUCCESFULLY ADDED \nNAME=" + name + "\nMobile: " + mobile, "Success", MessageBoxButtons.OK);

                var newForm =new  AdminPanel(this.admin);
                this.Hide();
                newForm.ShowDialog();
                this.Dispose();

                
            }
        }
    }
}
