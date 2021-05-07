using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private int mProductId;
        private string mProductName;
        private DateTime mReleaseDate;
        private decimal mPrice;
        private bool mInStock;
        private string mProductDescription;

        public int ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }

        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return mReleaseDate;
            }
            set
            {
                mReleaseDate = value;
            }
        }
        public decimal Price
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

        public string ProductDescription
        {
            get
            {
                return mProductDescription;
            }
            set
            {
                mProductDescription = value;
            }
        }

        public bool Find(int ProductId)
        {
            //set private data members to test data value
            mProductId = 11;
            mProductName = "Game 1";
            mReleaseDate = Convert.ToDateTime("01/01/2001");
            mPrice = Convert.ToDecimal(10.00);
            mInStock = true;
            mProductDescription = "A game.";
            return true;
        }

        public string Valid(int productId,
                            string productname,
                            DateTime releaseDate,
                            decimal price,
                            bool inStock,
                            string productDesc)
        {
            string Error = "";
            DateTime DateTemp;
            if (productId < 0)
            {
                Error = Error + "The product ID cannot be negative : ";
            }

            return Error;
        }
    }
}