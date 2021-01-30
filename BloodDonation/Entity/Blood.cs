using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodDonation;
using System.Data;
namespace BloodDonation.Entity
{
    public class Blood
    {
        public static string getNumberOfAvailableDonor(string bloodGroup,string rh)
        {



            string query = "select* from donor where bloodGroup = '"+bloodGroup+"' and rh = '"+rh+"' and DateDiff(day, lastDonationDate, GetDate()) > 60;";

            var dt = DataAccess.GetDataTable(query);

            int count = dt.Rows.Count;

            return count.ToString();
        }

        public static DataTable getDonorNameList(string bloodGroup,string rh)
        {
            string query = "Select id,name from Donor where bloodGroup = '" + bloodGroup + "' and rh = '" + rh + "' and DateDiff(day, lastDonationDate, GetDate()) > 60;";
            var dt = DataAccess.GetDataTable(query);
            return dt;
        }


        public static string GetDonationId()
        {

            string query = "select TOP 1 * from DonationList ORDER BY id DESC";
            var dt = DataAccess.GetDataTable(query);

            string id = dt.Rows[0]["id"].ToString();

            string idNumberPart = id[1].ToString() + id[2].ToString() + id[3].ToString();

            int myInt = Convert.ToInt32(idNumberPart);

            myInt++;

            return "L"+myInt.ToString();

            
        }

        public static void InsertDonationRecord(string id,string date,string details,string bloodGroup,string donorId,string adminId)
        {
            string query = "Insert into DonationList(id,date,details,donorId,adminId,bloodGroup) values('"+id+"','"+date+"','"+details+"','"+donorId+"','"+adminId+"','"+bloodGroup+"');";

            string updateQuery = "UPDATE Donor SET lastDonationDate ='"+date+"' where id='"+donorId+"';";
            
            
            DataAccess.ExecuteUpdateQuery(query);
            DataAccess.ExecuteUpdateQuery(updateQuery);

        }

        public static DataTable GetDonationHistory(string donorId)
        {
            string query = "Select * from DonationList where donorId='"+donorId+"' ORDER BY date ;";

            var dt = DataAccess.GetDataTable(query);

            return dt;
        }

        public static DataTable GetDonationHistory()
        {
            string query = "Select * from DonationList where id !='L100' ORDER BY date;";

            var dt = DataAccess.GetDataTable(query);

            return dt;
        }

    }
}
