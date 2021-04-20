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
            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.CustomerId = 4;
            TestItem.Name = "Zeynep Tugce";
            TestItem.CustomerRegisteredDate = DateTime.Now.Date;
            TestItem.ProductId = 40;
            TestItem.Point = 0;
        
            mCustomerList.Add(TestItem);

            TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.CustomerId = 3;
            TestItem.Name = "Nursah Demi";
            TestItem.CustomerRegisteredDate = DateTime.Now.Date;
            TestItem.ProductId = 30;
            TestItem.Point = 20;

            mCustomerList.Add(TestItem);
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