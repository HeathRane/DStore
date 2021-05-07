using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Int32 StaffNumber;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)

    {
        clsStaff AStaff = new clsStaff();
        //capture the info.
        string StaffNumber = txtStaffNumber.Text;
        string StaffName = txtStaffName.Text;
        string StaffSalary = txtStaffSalary.Text;
        string StaffCredit = txtStaffCredit.Text;
        string StaffDate = txtStaffDate.Text;
        string StaffStatus = chkStatus.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffNumber,StaffName, StaffSalary, StaffCredit, StaffDate,StaffStatus);
        if(Error =="")
        {
            //capture the info.
            
            AStaff.StaffName = StaffName;
            AStaff.StaffNumber = Convert.ToInt32(StaffNumber);
            AStaff.StaffStatus = chkStatus.Checked;
            AStaff.StaffCredit = Convert.ToInt32(StaffCredit);
            AStaff.StaffSalary = Convert.ToDouble(StaffSalary);
            AStaff.StaffDate = Convert.ToDateTime(StaffDate);
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = AStaff;
            StaffList.Add();
            Response.Write("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        

        
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

    protected void chkStatus_CheckedChanged(object sender, EventArgs e)
    {

    }
}