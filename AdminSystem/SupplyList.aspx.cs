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
            DisplaySuppliers();
        }


    }

    void DisplaySuppliers()
    {
        clsSupplyCollection Suppliers = new clsSupplyCollection();
        //set the data source to the list of the to the list of names in the collection
        lstSuppliers.DataSource = Suppliers.SupplyList;
        //set the name of the primary key 
        lstSuppliers.DataValueField = "ProductID";
        //set the field to display
        lstSuppliers.DataTextField = "Name";
        //bind the data to the list 
        lstSuppliers.DataBind();
    }

    protected void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("SupplyDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductID; 
        if(lstSuppliers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstSuppliers.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the edit page
            Response.Redirect("SupplyDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select item to edit ";
        }
    }

    protected void btnDeletete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 ProductID; 
        if(lstSuppliers.SelectedIndex != -1 )
        {
            //get the primary key value of the record to delete 
            ProductID = Convert.ToInt32(lstSuppliers.SelectedValue);
            //store the data in the session object 
            Session["ProductID"] = ProductID;
            //redirect to the delete page 
            Response.Redirect("SupplyConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record to delete from the list";
        }
    }
}