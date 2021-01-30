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
    public partial class DonationHistory : Form
    {
        Admin admin;
        public DonationHistory(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;

            var dt = Blood.GetDonationHistory();
            this.dtgvHistory.AutoGenerateColumns = false;
            this.dtgvHistory.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                var newForm = new AdminPanel(admin);
                newForm.ShowDialog();
                this.Dispose();
          

        }
    }
}
