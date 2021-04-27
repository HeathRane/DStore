using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            if(CustomerId != -1)
            {
                DisplayCustomers();
            }
            
        }
    }
    void DisplayCustomers ()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        Customers.ThisCustomer.Find(CustomerId);

        lstCustomersList.DataSource = Customers.CustomerList; 
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "Name";
        lstCustomersList.DataBind();

        txtCustomerId.Text = Customers.ThisCustomer.CustomerId.ToString();
        txtName.Text = Customers.ThisCustomer.Name;
        txtCustomerRegisteredDate.Text = Customers.ThisCustomer.CustomerRegisteredDate.ToString();
        txtProductId.Text = Customers.ThisCustomer.ProductId.ToString();
        txtPoint.Text = Customers.ThisCustomer.Point.ToString();
        chkActive.Checked = Customers.ThisCustomer.Active;

        

    }
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Session["CustomerId"] = CustomerId;

        Response.Redirect("theCustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomersList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomersList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }


    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {

        Int32 CustomerId;

        if (lstCustomersList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomersList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("theCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}