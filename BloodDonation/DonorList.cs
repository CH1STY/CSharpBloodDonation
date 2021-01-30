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
    public partial class DonorList : Form
    {
        Admin admin;
        public DonorList(Admin adObj)
        {
            InitializeComponent();

            this.admin = adObj;

            PopulateDonorGrid();
        }


        private void PopulateDonorGrid()
        {
            string query = "Select * from Donor order by id;";
            var dt = DataAccess.GetDataTable(query);

            this.dtgvDonorList.AutoGenerateColumns = false;
           

            this.dtgvDonorList.DataSource = dt;

           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new AdminPanel(admin);
            newForm.ShowDialog();
            this.Dispose();
        }

        private void DonorList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodDonationMgtDataSet.Donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.bloodDonationMgtDataSet.Donor);

        }

        private void dtgvDonorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dtgvDonorList.Columns["detailsBtn"].Index)
            {
                int rowIndex = e.RowIndex;

                string donorId = this.dtgvDonorList.Rows[rowIndex].Cells[1].Value.ToString();


                var donorObj = Donor.getDonorObject(donorId);

                var newForm = new DonarDetails(admin, donorObj);
                this.Hide();
                newForm.ShowDialog();
                this.Dispose();

              
            }
        }
    }
}
