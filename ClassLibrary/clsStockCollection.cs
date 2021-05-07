using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mProductsList = new List<clsStock>();
        clsStock mThisProduct = new clsStock();

        public List<clsStock> ProductsList
        {
            get
            {
                return mProductsList;
            }
            set
            {
                mProductsList = value;
            }
        }

        public int Count
        {
            get
            {
                return mProductsList.Count;
            }
            set
            {

            }
        }

        public clsStock ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

        public clsStockCollection()
        {
            int Index = 0;
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblProduct_SelectAll");

            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ReleaseDate", mThisProduct.ReleaseDate);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);

            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ReleaseDate", mThisProduct.ReleaseDate);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);

            DB.Execute("sproc_tblProduct_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("ProductId", mThisProduct.ProductId);
            DB.Execute("sproc_tblProduct_Delete");
        }

        public void ReportByPrice(decimal Price)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Price", Price);
            DB.Execute("sproc_tblProduct_FilterByPrice");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int Index = 0;
            int RecordCount = 0;
            RecordCount = DB.Count;
            mProductsList = new List<clsStock>();

            while (Index < RecordCount)
            {
                clsStock AProduct = new clsStock();

                DB.AddParameter("@ProductId", mThisProduct.ProductId);
                DB.AddParameter("@ProductName", mThisProduct.ProductName);
                DB.AddParameter("@ReleaseDate", mThisProduct.ReleaseDate);
                DB.AddParameter("@Price", mThisProduct.Price);
                DB.AddParameter("@InStock", mThisProduct.InStock);
                DB.AddParameter("@ProductDescription", mThisProduct.ProductDescription);

                mProductsList.Add(AProduct);
                Index++;
            }
        }
    }
}
