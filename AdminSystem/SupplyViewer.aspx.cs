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
        //create a new instance of clsSupply
        clsSupply TheSupplier = new clsSupply();
        TheSupplier = (clsSupply)Session["TheSupplier"];
        //display the Supplier Name for this entry 
        Response.Write(TheSupplier.Name);
    }
}