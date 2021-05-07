using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // clsStock instantiation
        clsStock AProduct = new clsStock();
        // capture data
        int productId = int.Parse(txtProductId.Text);
        string productName = txtProductName.Text;
        DateTime releaseDate = Convert.ToDateTime(txtReleaseDate.Text);
        Decimal price = Decimal.Parse(txtPrice.Text);
        bool inStock = chkInStock.Checked;
        string productDesc = txtProductName.Text;

        // validation
        string Error = "";
        Error = AProduct.Valid(productId, productName, releaseDate, price, inStock, productDesc);
        if (Error == "")
        {
            // capture data
            AProduct.ProductId = int.Parse(txtProductId.Text);
            AProduct.ProductName = txtProductName.Text;
            AProduct.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
            AProduct.Price = Decimal.Parse(txtPrice.Text);
            AProduct.InStock = chkInStock.Checked;
            AProduct.ProductDescription = txtProductName.Text;

            clsStockCollection ProductList = new clsStockCollection();

            if (productId == -1)
            {
                ProductList.ThisProduct = AProduct;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(productId);
                ProductList.ThisProduct = AProduct;
                ProductList.Update();
            }

            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // clsStock instantiation
        clsStock AProduct = new clsStock();
        // variable to store the primary key
        int ProductId;
        // variable to store find operation result
        Boolean Found = false;
        // get primary key entered by user
        ProductId = Convert.ToInt32( txtProductId.Text );
        //find record
        Found = AProduct.Find(ProductId);
        // if found
        if (Found)
        {
            // display values of the properties in the form
            txtProductName.Text = AProduct.ProductName;
            txtProductDescription.Text = AProduct.ProductDescription;
            txtReleaseDate.Text = AProduct.ReleaseDate.ToString();
            txtPrice.Text = AProduct.Price.ToString();
            chkInStock.Checked = AProduct.InStock;
        }
    }
}