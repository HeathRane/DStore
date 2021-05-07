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
            DisplayProducts();
        }

    }

    void DisplayProducts()
    {
        clsStockCollection Products = new clsStockCollection();

        lstProductsList.DataSource = Products.ProductsList;
        lstProductsList.DataValueField = "ProductId";
        lstProductsList.DataTextField = "ProductName";
        lstProductsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductId"] = -1;
        Response.Redirect("AProduct.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int ProductId;

        if (lstProductsList.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstProductsList.SelectedValue);
            Session["ProductId"] = ProductId;
            Response.Redirect("AProduct.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int ProductId;
        if (lstProductsList.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstProductsList.SelectedValue);
            Session["ProductId"] = ProductId;
            Response.Redirect("DeleteAddress.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStockCollection Products = new clsStockCollection();
        Products.ReportByPrice(Convert.ToDecimal(txtFilter.Text));
        lstProductsList.DataSource = Products.ProductsList;
        lstProductsList.DataValueField = "ProductId";
        lstProductsList.DataTextField = "Price";
        lstProductsList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Products = new clsStockCollection();
        Products.ReportByPrice(Convert.ToDecimal(0));
        lstProductsList.DataSource = Products.ProductsList;
        lstProductsList.DataValueField = "ProductId";
        lstProductsList.DataTextField = "Price";
        lstProductsList.DataBind();
    }
}