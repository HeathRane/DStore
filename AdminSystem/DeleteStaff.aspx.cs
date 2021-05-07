using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 StaffNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNumber = Convert.ToInt32(Session["StaffNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staffes = new clsStaffCollection();

        Staffes.ThisStaff.Find(StaffNumber);

        Staffes.Delete();

        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}