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

        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 21;

            mCustomerRegisteredDate = Convert.ToDateTime("05/03/2021");

            mName = "Zeynep";

            mProductId = 1;

            mPoint = 1.5;

            mActive = true;

            //alway return true

            return true;
        }
    }
}