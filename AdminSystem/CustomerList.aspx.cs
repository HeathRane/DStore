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
                
        lstCustomersList.DataSource = Customers.CustomerList; 
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "Name";
        lstCustomersList.DataBind();

               

    }
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Session["CustomerId"] = -1 ;

        Response.Redirect("CustomerDataEntry.aspx");
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
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        Customers.ReportByName(txtFilter.Text);
        
        lstCustomersList.DataSource = Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "Name";
        lstCustomersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        Customers.ReportByName("");
        txtFilter.Text = "";

        lstCustomersList.DataSource = Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "Name";
        lstCustomersList.DataBind();
    }
}