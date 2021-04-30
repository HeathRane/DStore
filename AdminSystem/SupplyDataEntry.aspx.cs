using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if(IsPostBack == false)
        {
            if(ProductID != -1)
            {
                DisplaySupplies();
            }
        }
    }

   





   

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupply
        clsSupply TheSupplier = new clsSupply();
        // capture the id 
        string id = txtProductID.Text;
        string Name = txtName.Text;
        
        string Quantity = txtQuantity.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string Price = txtPrice.Text;
        string error = "";

        error = TheSupplier.Valid(id, Quantity, Name, Price, DeliveryDate);
        if (error == "") {
            TheSupplier.ProductID = ProductID;
            TheSupplier.Price = Convert.ToInt32(Price);
            TheSupplier.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            TheSupplier.Quantity = Convert.ToInt32(Quantity);
            TheSupplier.Name = Name;
            TheSupplier.InStock = chkInStock.Checked;
            //Store the addres in the session object
            //Session["TheSupplier"] = TheSupplier;
            clsSupplyCollection colelction = new clsSupplyCollection();
            if(ProductID ==-1)
            {
                colelction.ThisSupply = TheSupplier;
                colelction.Add();
            }
            else
            {
                colelction.ThisSupply.Find(ProductID);
                colelction.ThisSupply = TheSupplier;
                colelction.Update();
            }
           

            //navigate to the viewer page
            Response.Redirect("SupplyList.aspx");

        } else
        {
            lblError.Text = error;
        }


        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupply Supplier = new clsSupply();
        Int32 ProductID;

        Boolean Found = false;

        ProductID = Convert.ToInt32(txtProductID.Text);

        Found = Supplier.Find(ProductID);

        if (Found == true)
        {
            txtName.Text = Supplier.Name.ToString();
            txtDeliveryDate.Text = Supplier.DeliveryDate.ToString();
            txtPrice.Text = Supplier.Price.ToString();
            txtQuantity.Text = Supplier.Quantity.ToString();
            chkInStock.Checked = Supplier.InStock;
        }
    }
    void DisplaySupplies()
    {
        clsSupplyCollection Supplies = new clsSupplyCollection();
        Supplies.ThisSupply.Find(ProductID);
        //display the edata for this record 
        txtProductID.Text = Supplies.ThisSupply.ProductID.ToString();
        txtName.Text = Supplies.ThisSupply.Name;
        txtPrice.Text = Supplies.ThisSupply.Price.ToString();
        txtQuantity.Text = Supplies.ThisSupply.Quantity.ToString();
        txtDeliveryDate.Text = Supplies.ThisSupply.DeliveryDate.ToString();
        chkInStock.Checked = Supplies.ThisSupply.InStock;
    }

   
}
