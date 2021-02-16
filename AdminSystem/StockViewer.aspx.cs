using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // clsStock instantiation
        clsStock AProduct = new clsStock();
        // get data from session object
        AProduct = (clsStock) Session["AProduct"];
        // display product name on page
        Response.Write(AProduct.ProductName);
    }
}