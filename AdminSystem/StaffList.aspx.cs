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
            DisplayStaffes();

        }
    }
    void DisplayStaffes()
    {

        clsStaffCollection Staffes = new clsStaffCollection();

        lstStaffList.DataSource = Staffes.StaffList;
        lstStaffList.DataValueField = "StaffNumber";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Session["StaffNumber"] = -1;

        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {

        Int32 StaffNumber;

        if (lstStaffList.SelectedIndex != -1)
        {
            StaffNumber = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffNumber"] = StaffNumber;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffes = new clsStaffCollection();

        Staffes.Filter(txtFilter.Text);

        lstStaffList.DataSource = Staffes.StaffList;
        lstStaffList.DataValueField = "StaffNumber";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffes = new clsStaffCollection();

        Staffes.Filter("");
        txtFilter.Text = "";

        lstStaffList.DataSource = Staffes.StaffList;
        lstStaffList.DataValueField = "StaffNumber";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 StaffNumber;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffNumber = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffNumber"] = StaffNumber;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}

