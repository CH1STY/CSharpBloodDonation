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
    public partial class DonarDetails : Form
    {

         Admin admin;
         Donor donor;
        
        public DonarDetails(Admin admin,Donor donor)
        {
            InitializeComponent();

            this.admin = admin;
            this.donor = donor;

            if(donor.Rh.Substring(0,8)=="Negative")
            {
                donor.Rh = "-";
            }
            else
            {
                donor.Rh = "+";
            }

            this.lblName.Text = "Name: "+donor.Name;
            this.lblMobile.Text = "Mobile: " + donor.Mobile;
            this.lblAddress.Text = "Address: "+donor.Address;
            this.lblSex.Text = "Sex: "+donor.Sex;
            this.lblBloodType.Text = "Blood Group: "+donor.BloodGroup.Substring(0,1) + donor.Rh;
            this.lblLastDonation.Text = "Last Donated(mm/dd/yyyy): " + donor.LastDonationDate;
            this.lblAge.Text = calculateAge(donor.Dob);

            var dt = Blood.GetDonationHistory(this.donor.Id);


            this.dtgvHistory.AutoGenerateColumns = false;
            this.dtgvHistory.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var newForm = new DonorList(admin);
            this.Hide();
            newForm.ShowDialog();
            this.Dispose();

        }

        private string calculateAge(string dob)
        {
            DateTime db = Convert.ToDateTime(dob);
            string Text = CalculateYourAge(db);


            return Text;
        }

        private string CalculateYourAge(DateTime db)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(db).Ticks).Year - 1;
            DateTime PastYearDate = db.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            return String.Format("Age: "+Years+" Year(s) "+Months+" Month(s) "+Days+" Day(s)");
        }   
           
        

    }
}
