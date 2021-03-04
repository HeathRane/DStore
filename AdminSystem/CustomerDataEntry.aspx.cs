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
        //create a new instance of clsCustomer
        clsCustomer theCustomer = new clsCustomer();
        //capture the CustomerId
        theCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //store the customerId in the session object
        Session["theCustomer"] = theCustomer;
        //navigate to the viewer paga
        Response.Redirect("CustomerViewer.aspx");
    }
}