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
        clsStaff AStaff = new clsStaff();

        AStaff.StaffName = txtStaffName.Text;

        Session["AStaff"] = AStaff;

        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffNumber;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNumber = Convert.ToInt32(txtStaffNumber.Text);
        //find the record
        Found = AStaff.Find(StaffNumber);
        //if found
        if(Found == true)
        {
            //display the values of the properrties in the form
            txtStaffNumber.Text = AStaff.StaffNumber.ToString();
            txtStaffName.Text = AStaff.StaffName;
            txtStaffSalary.Text = AStaff.StaffStatus.ToString();
            txtStaffCredit.Text = AStaff.StaffCredit.ToString();
            txtStaffSalary.Text = AStaff.StaffSalary.ToString();
            txtStaffDate.Text = AStaff.StaffDate.ToString();

        }

    }
}