using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Entity
{

    public class Donor
    {
        private string id, name, dob, mobile, address, bloodGroup, rh, sex, adminId, lastDonationDate;

        public Donor()
        {

        }
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

        public string Dob
        {
            set
            {
                this.dob = value;
            }
            get
            {
                return this.dob;
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

        public string Address
        {
            set
            {
                this.address = value;
            }
            get
            {
                return this.address;
            }
        }

        public string BloodGroup
        {
            set
            {
                this.bloodGroup = value;
            }
            get
            {
                return this.bloodGroup;
            }
        }

        public string Rh
        {
            set
            {
                this.rh = value;
            }
            get
            {
                return this.rh;
            }
        }

        public string Sex
        {
            set
            {
                this.sex = value;
            }
            get
            {
                return this.sex;
            }
        }

        public string AdminId
        {
            set
            {
                this.adminId = value;
            }
            get
            {
                return this.adminId;
            }
        }

        public string LastDonationDate
        {
            set
            {
                this.lastDonationDate = value;
            }
            get
            {
                return this.lastDonationDate;
            }
        }

        public Donor(string id, string name, string dob,string mobile, string address, string bloodGroup, string rh, string sex, string adminId, string lastDonationDate) {

            this.Id = id;
            this.Name = name;
            this.Dob = dob;
            this.Mobile = mobile;
            this.Address = address;
            this.BloodGroup = bloodGroup;
            this.Rh = rh;
            this.Sex = sex;
            this.AdminId = adminId;
            this.LastDonationDate = lastDonationDate;
        }


        private static int getNextDonorId()
        
        {
            string query = "select TOP 1 * from Donor ORDER BY id DESC";

            var dt = DataAccess.GetDataTable(query);

            string idValueInString = dt.Rows[0]["id"].ToString();

            string idValue = idValueInString[1].ToString() + idValueInString[2].ToString() + idValueInString[3].ToString();

            int idValueToReturn = Convert.ToInt32(idValue);
            idValueToReturn++;

            return idValueToReturn;



        }

        public static void InsertIntoDonor(string name,string mobile,string sex,string address, string dob, string bloodGroup, string rh, string lastDateOfDonation, string adminId)
        {
            string id = getNextDonorId().ToString();

            id = "D" + id;

            string query = "Insert into Donor(id,name,dob,mobile,address,bloodGroup,rh,sex,adminId,lastDonationDate) values('"+id+"','"+name+"','"+dob+"','"+mobile+"','"+address+"','"+bloodGroup+"','"+rh+"','"+sex+"','"+adminId+"','"+lastDateOfDonation+"')";

            DataAccess.ExecuteUpdateQuery(query);

        }

        public static Donor getDonorObject(string donorId)
        {

            donorId = donorId.Substring(0, 4);

            string query = "Select * from Donor where id = '" + donorId + "'";

         

            var dt = DataAccess.GetDataTable(query);

            string id, name, dob, mobile, address, bloodGroup, rh, sex, adminId, lastDonationDate;

            id = donorId;
            name = dt.Rows[0]["name"].ToString();
            dob = dt.Rows[0]["dob"].ToString();

            int dobIndex = dob.IndexOf(' ');

            dob = dob.Substring(0, dobIndex);

            mobile = dt.Rows[0]["mobile"].ToString();
            address = dt.Rows[0]["address"].ToString();
            bloodGroup = dt.Rows[0]["bloodGroup"].ToString();
            rh = dt.Rows[0]["rh"].ToString();
            sex = dt.Rows[0]["sex"].ToString();
            adminId = dt.Rows[0]["adminId"].ToString();
            lastDonationDate = dt.Rows[0]["lastDonationDate"].ToString();
            int lddIndex = lastDonationDate.IndexOf(' ');

            lastDonationDate = lastDonationDate.Substring(0, lddIndex);



            var returningDonorObj = new Donor(id, name, dob, mobile, address, bloodGroup, rh, sex, adminId, lastDonationDate);

            return returningDonorObj;

            

        }

    }
}
