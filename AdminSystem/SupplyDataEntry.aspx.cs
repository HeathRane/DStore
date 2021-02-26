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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupply
        clsSupply TheSupplier = new clsSupply();
        // capture the id 
        TheSupplier.Name = txtName.Text;
        //Store the addres in the session object
        Session["TheSupplier"] = TheSupplier;
  
        //navigate to the viewer page
        Response.Redirect("SupplyViewer.aspx");
    }





    protected void btnOk_Click1(object sender, EventArgs e)
    {
        
            //create a new instance of clsSupply
            clsSupply TheSupplier = new clsSupply();
            // capture the id 
            TheSupplier.Name = txtName.Text;
            //Store the addres in the session object
            Session["TheSupplier"] = TheSupplier;

            //navigate to the viewer page
            Response.Redirect("SupplyViewer.aspx");
        
    }
}