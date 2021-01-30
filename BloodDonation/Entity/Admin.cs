using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodDonation;

namespace BloodDonation.Entity
{
    public class Admin
    {
        private string id;
        private string password;
        private string name;
        private string mobile;

        public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public string Password
        {
            set
            {
                this.password = value;
            }
            get
            {
                return this.password;
            }
        }

        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        public string Mobile
        {
            set
            {
                this.mobile = value;
            }
            get
            {
                return this.mobile;
            }
        }

        public static void InsertAdmin(string id,string password,string name, string mobile)
        {
            string query = "Insert into admin(id, password, name, mobile) values('"+id+"','"+password+"','"+name+"','"+mobile+"');";
            DataAccess.ExecuteUpdateQuery(query);

        }

        public static int GetLastAdminIdNumber()
        {

            string query = "select TOP 1 * from admin ORDER BY id DESC";
            var dt = DataAccess.GetDataTable(query);

            string id = dt.Rows[0]["id"].ToString();

            string idNumberPart = id[1].ToString() + id[2].ToString() + id[3].ToString();

            int myInt = Convert.ToInt32(idNumberPart);

            return myInt;




        }

        public Admin()
        {

        }
        public Admin(string id,string password, string name, string mobile )
        {
            this.Id = id;
            this.Password = password;
            this.Name = name;
            this.Mobile = mobile;
        }

    }
}
