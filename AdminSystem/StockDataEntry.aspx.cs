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
        // capture product name
        AProduct.ProductName = txtProductName.Text;
        // store name in session object
        Session["AProduct"] = AProduct;
        // navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}