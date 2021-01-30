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
    public partial class AdminReg : Form
    {

        Admin admin;
        public AdminReg(Admin adObj)
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
            //VALIDATION STARTS

            if(String.IsNullOrEmpty(this.txtName.Text))
            {
                flag = true;
                this.lblErrorName.Text = "Name can't be empty";
                this.lblErrorName.Visible = true;
            }
            else
            {
                this.lblErrorName.Visible = false;
            }

            if (String.IsNullOrEmpty(this.txtPassword.Text))
            {
                flag = true;
                this.lblErrorPassword.Text = "Password can't be empty";
                this.lblErrorPassword.Visible = true;
            }
            else
            {
                this.lblErrorPassword.Visible = false;

            }

            if(this.txtPassword.Text != this.txtCfmPassword.Text)
            {
                flag = true;
                this.lblCfmPasswordError.Text = "Password doesn't Match";
                this.lblCfmPasswordError.Visible = true;
            }
            else
            {
                this.lblCfmPasswordError.Visible = false;

            }


            if (String.IsNullOrEmpty(this.txtMobile.Text))
            {
                flag = true;
                this.lblErrorMobile.Text = "Mobile number  can't be empty";
                this.lblErrorMobile.Visible = true;
            }
            else
            {
                this.lblErrorMobile.Visible = false;
            }

            // VALIDATION ENDS


            if (!flag)
            {
                int myInt = Admin.GetLastAdminIdNumber();
                myInt++;
                string id = "A" + myInt.ToString();
                string name = this.txtName.Text;
                string password = this.txtPassword.Text;
                string mobile = this.txtMobile.Text;

                Admin.InsertAdmin(id,password,name,mobile);

                MessageBox.Show("ADMIN SUCCESFULLY ADDED \nID=" + id +"\nPassword: "+password,"Success",MessageBoxButtons.OK);

                var newForm = new AdminPanel(this.admin);
                this.Hide();
                newForm.ShowDialog();
                this.Dispose();


            }
        }
    }
}
