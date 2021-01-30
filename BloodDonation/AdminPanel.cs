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
    public partial class AdminPanel : Form
    {
        private Admin admin;

        public AdminPanel(Admin adObj)
        {
            InitializeComponent();

            this.admin = adObj;
            this.lblId.Text = "Admin Id: " + admin.Id;
            this.lblName.Text = "Admin Name: " + admin.Name;
            this.lblMobile.Text = "MOBILE NUMBER : " + admin.Mobile;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new LoginForm();
            newForm.ShowDialog();
            this.Dispose();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            var newForm = new AdminReg(admin);
            this.Hide();
            newForm.ShowDialog();
            this.Dispose();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            var newForm = new AddDonor(admin);
            this.Hide();
            newForm.ShowDialog();
            this.Dispose();
        }

        private void btnViewDonorList_Click(object sender, EventArgs e)
        {
            var newForm = new DonorList(admin);
            this.Hide();
            newForm.ShowDialog();
            this.Dispose();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            this.txtABNegNumber.Text = Blood.getNumberOfAvailableDonor("AB", "Negative");
            this.txtABposNumber.Text = Blood.getNumberOfAvailableDonor("AB", "Positive");
            this.txtBNegNumber.Text = Blood.getNumberOfAvailableDonor("B", "Negative");
            this.txtBposNumber.Text = Blood.getNumberOfAvailableDonor("B", "Positive");
            this.txtANegNumber.Text = Blood.getNumberOfAvailableDonor("A", "Negative");
            this.txtAposNumber.Text = Blood.getNumberOfAvailableDonor("A", "Positive");
            this.txtONegNumber.Text = Blood.getNumberOfAvailableDonor("O", "Negative");
            this.txtOposNumber.Text = Blood.getNumberOfAvailableDonor("O", "Positive");

        }

        private void btnProvideBlood_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new AddDonation(admin);
            newForm.ShowDialog();
            this.Dispose();
        }

        private void btnDonationHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new DonationHistory(admin);
            newForm.ShowDialog();
            this.Dispose();
        }
    }
}
