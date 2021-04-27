using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_table_Customer_SelectAll");

            PopulateArray(DB);

        }
        void PopulateArray (clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();

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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFullName", mThisCustomer.Name);
            DB.AddParameter("@CustomerActivity", mThisCustomer.Active);
            DB.AddParameter("@RegisteredDate", mThisCustomer.CustomerRegisteredDate);
            DB.AddParameter("@CustomerPoint", mThisCustomer.Point);
            DB.AddParameter("ProductID", mThisCustomer.ProductId);

            return DB.Execute("sproc_table_Customer_Insert");
        }

        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFullName", mThisCustomer.Name);
            DB.AddParameter("@CustomerActivity", mThisCustomer.Active);
            DB.AddParameter("@RegisteredDate", mThisCustomer.CustomerRegisteredDate);
            DB.AddParameter("@CustomerPoint", mThisCustomer.Point);
            DB.AddParameter("ProductID", mThisCustomer.ProductId);

            return DB.Execute("sproc_table_Customer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection ();

            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);

            DB.Execute("sproc_table_Customer_Delete");
        }

        public void ReportByName(string v)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductId", Name);

            DB.Execute("sproc_table_Customer_FilterByProductId");

            PopulateArray(DB);
        }
    }
   
}