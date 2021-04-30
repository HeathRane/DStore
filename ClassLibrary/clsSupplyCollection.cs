using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsSupplyCollection
    {
        clsSupply mThisSupply = new clsSupply();
        List<clsSupply> mSupplyList = new List<clsSupply>();
        public clsSupply ThisSupply
        {
            get
            {
                return mThisSupply;
            }
            set
            {
                mThisSupply = value;
            }
        }
        public List<clsSupply> SupplyList
        {
            get
            {
                return mSupplyList;
            }
            set
            {
                mSupplyList = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplyList.Count;
            }
            set
            {

            }
        }
        public clsSupplyCollection()
        {
            Int32 Index = 0;
            Int32 Recordcount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupply_SelectAll");
            Recordcount = DB.Count;
            while(Index < Recordcount)
            {
                clsSupply Supplier = new clsSupply();
                Supplier.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                Supplier.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                Supplier.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                Supplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Supplier.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                Supplier.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);

                mSupplyList.Add(Supplier);
                Index++;
                
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Price", mThisSupply.Price);
            DB.AddParameter("@Quantity", mThisSupply.Quantity);
            DB.AddParameter("@Name", mThisSupply.Name);
            DB.AddParameter("@InStock", mThisSupply.InStock);
            DB.AddParameter("@DeliveryDate", mThisSupply.DeliveryDate);

           return  DB.Execute("sproc_tblSupply_Insert");

        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisSupply.ProductID);
            DB.AddParameter("@Price", mThisSupply.Price);
            DB.AddParameter("@Quantity", mThisSupply.Quantity);
            DB.AddParameter("@Name", mThisSupply.Name);
            DB.AddParameter("@InStock", mThisSupply.InStock);
            DB.AddParameter("@DeliveryDate", mThisSupply.DeliveryDate);

             DB.Execute("sproc_tblSupply_Update");
        }

        public void Delete()
        {
            //deletes the recortd poitned to by thisAddress
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisSupply.ProductID);
            DB.Execute("sproc_tblSupply_Delete");
        }

        public void ReportByName(string name)
        {
            //filters the recotrds based on a Name 
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the database 
            DB.AddParameter("@Name", name);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupply_FilterByName");
        }
        public void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB 
            // var for the index 
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            //clear the private array 
            mSupplyList = new List<clsSupply>();
            //while there are records to process 
            while(Index < RecordCount)
            {
                //create a blank address 
                clsSupply Supplier = new clsSupply();
                //read in the fields from the current record 
                Supplier.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                Supplier.ProductID = Convert.ToString(DB.)
            }
        }
    }
}
