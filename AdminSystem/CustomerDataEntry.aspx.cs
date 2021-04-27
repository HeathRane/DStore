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
        clsCustomer theCustomer = new clsCustomer();
        theCustomer = (clsCustomer)Session["theCustomer"];
        Response.Write(theCustomer.CustomerId);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer theCustomer = new clsCustomer();

        //capture the full name
        string Name = txtFullName.Text;

        //capture registered date
        string RegisteredDate = txtRegisteredDate.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = theCustomer.Valid(RegisteredDate, Name);
        if (Error == "")
        {
            //capture the name
            theCustomer.Name = Name;
            //capture the registered date
            theCustomer.CustomerRegisteredDate = Convert.ToDateTime(RegisteredDate);
            //capture customerId
            theCustomer.CustomerId = Convert.ToInt32(CustomerId);
            //capture Active
            theCustomer.Active = Active.Checked;
            //capture productId
            theCustomer.ProductId = Convert.ToInt32(ProductId);
            //capture point
            theCustomer.Point = Convert.ToDouble(CustomerPoint);

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = theCustomer;

                CustomerList.Add();
            }

            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);

                CustomerList.ThisCustomer = theCustomer;

                CustomerList.Update();

            }

            Response.Redirect("CustomerList.aspx");
                        
        }
        else
        {
            lblError.Text = "Error";
        }
            
    }
    
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer theCustomer = new clsCustomer ();

        Int32 CustomerId;

        Boolean Found = false;

        CustomerId = Convert.ToInt32(txtCustomerId.Text);

        Found = theCustomer.Find(CustomerId);

        if (Found == true)
        {
            txtFullName.Text = theCustomer.Name;
            txtRegisteredDate.Text = theCustomer.CustomerRegisteredDate.ToString();
            Active.Text = theCustomer.Active.ToString();
            txtCustomerPoint.Text = theCustomer.Point.ToString ();
            txtProductId.Text = theCustomer.ProductId.ToString () ;
        }
    }

}