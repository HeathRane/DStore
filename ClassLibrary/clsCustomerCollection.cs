using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_table_Customer_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer theCustomer = new clsCustomer();

                theCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["CustomerActivity"]);
                theCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                theCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFullName"]);
                theCustomer.CustomerRegisteredDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegisteredDate"]);
                theCustomer.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                theCustomer.Point = Convert.ToDouble(DB.DataTable.Rows[Index]["CustomerPoint"]);

                mCustomerList.Add(theCustomer);

                Index++;
            }
        }
     
        public clsCustomer ThisCustomer;
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }

            set
            {

            }
        }

    }
}