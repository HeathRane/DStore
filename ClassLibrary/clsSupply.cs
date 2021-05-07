using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        private Int32 mProductID;
        private bool mInStock;
        private string mName;
        private double mPrice;
        private DateTime mDeliveryDate;
        private int mQuantity;


        public bool InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }



        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }




        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }




        public Int32 ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }

        public DateTime DeliveryDate
        {
            get
            {
                return mDeliveryDate;
            }
            set
            {
                mDeliveryDate = value;
            }
        }



        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductID", ProductID);

            DB.Execute("sproc_tblSupply_FilterByProductID");

            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string ID ,string SupplierQuantity, string SupplierName, string SupplierPrice,string date)
        {
            String Error = "";

            if (SupplierQuantity.Length == 0)
            {
                Error = Error + "SupplierQuantity cant be null :";
            }

            try
            {

                if (Convert.ToInt32(SupplierQuantity) < 0)
                {
                    Error = Error + "SupplierQuantity cant be less than 0 :";
                }

            }
            catch (FormatException)
            {
                Error = Error + "SupplierQuantity must be a number :";
            }


            if (SupplierName.Length == 0)
            {
                Error = Error + "SupplierName cant be null :";

            }

            if (SupplierName.Length > 200)
            {
                Error = Error + "SupplierName length cant be greater than 200 :";
            }

            if (SupplierPrice.Length == 0)
            {
                Error = Error + "SupplierPrice cant be null :";
            }

            try
            {
                if (Convert.ToDouble(SupplierPrice) < 0.00)
                {
                    Error = Error + "SupplierPrice cant be negative :";
                }

            }
            catch (FormatException)
            {
                Error = Error + "SupplierPrice must be a decimal :";
            }

            return Error;
        }
    }
}


    

