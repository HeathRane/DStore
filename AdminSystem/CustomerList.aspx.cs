using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers ()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerId";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();

    }
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Session["CustomerId"] = -1;

        Response.Redirect("theCustomer.aspx");
    }
}