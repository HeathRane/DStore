using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page

    
{
    Int32 ProductID;
    //object handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted frpom the session object 
        ProductID = Convert.ToInt32(Session[ProductID]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSupplyCollection collection = new clsSupplyCollection();
        //find the record to delete 
        collection.ThisSupply.Find(ProductID);
        //delete the record 
        collection.Delete();
        //redirect back to the main page 
        Response.Redirect("SupplyList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplyList.aspx");
    }
}