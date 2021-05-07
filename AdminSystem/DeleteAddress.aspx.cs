using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteAddress : System.Web.UI.Page
{
    int ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStockCollection ProductsList = new clsStockCollection();
        ProductsList.ThisProduct.Find(ProductId);
        ProductsList.Delete();
        Response.Redirect("AddressList.aspx");
    }
}