using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //customerId private member variable
        private Int32 mCustomerId;
        //registeredDate private property
        private DateTime mCustomerRegisteredDate;
        //Name private member variable
        private String mName;
        //productId private member variable
        private Int32 mProductId;
        //point private member variable
        private double mPoint;
        //active private member variable
        private Boolean mActive;

        public bool Active {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        //CustomerRegisteredDate public property
        public DateTime CustomerRegisteredDate {
            get
            {
                return mCustomerRegisteredDate;
            }
            set
            {
                mCustomerRegisteredDate = value;
            }
        }
        public string Name {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        
        //CustomerId public property
        public Int32 CustomerId {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
                }
        public double Point {
            get
            {
                return mPoint;
            }
            set
            {
                mPoint = value;
            }
        }
        public int ProductId {
            get
            {
                //this line of code sends data out of the property
                return mProductId;
            }

            set
            {
                //this line of code allows data into the property
                mProductId = value;
            }
        }

        public bool Find(int CustomerId)
        {
            //create an intance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerId", CustomerId);

            //execute the stored procedure
            DB.Execute("sproc_table_Customer_FilterByCustomerID");

            //if one record is found (there is should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerRegisteredDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RegisteredDate"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mPoint = Convert.ToDouble(DB.DataTable.Rows[0]["CustomerPoint"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["CustomerActivity"]);

                //return that everything worked okay
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
                     
        }
    }
}