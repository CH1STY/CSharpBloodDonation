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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (String.IsNullOrEmpty(txtUserId.Text) || String.IsNullOrEmpty(txtUserPass.Text))
            {
                flag = true;
                lblEmptyError.Text = "ID or Password Can't Be Empty";
                lblEmptyError.Visible = true;

            }
            else
            {
                lblEmptyError.Visible = false;

            }

            if(!flag)
            {
                string query, id, password;
                id = txtUserId.Text;
                password = txtUserPass.Text;

                query = "Select * from admin where id = '" + id + "' and password = '" + password + "';";
               
                var dt = DataAccess.GetDataTable(query);
                if (dt.Rows.Count == 0)
                {
                    lblEmptyError.Text = "Login Credintials Error";
                    lblEmptyError.Visible = true;
                }
                else
                {
                    lblEmptyError.Visible = false;
                    string name = dt.Rows[0]["name"].ToString();
                    string mobile = dt.Rows[0]["mobile"].ToString();

                    Admin newAdmin = new Admin(id,password,name,mobile);
                    this.Hide();
                    var newForm = new AdminPanel(newAdmin);
                    newForm.ShowDialog();
                    this.Dispose();



                }
            }
        }
    }
}
