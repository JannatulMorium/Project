using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using DAO;
using Model;

public partial class UI_AddSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Supplier supplier = new Supplier();
        //supplier.SupplierID = Convert.ToInt32(txtId.Text);
        supplier.Name = txtName.Text;
        supplier.Address = txtAddress.Text;
        supplier.Phone = txtPhone.Text;
        supplier.Cell = txtCell.Text;
        SupplierDAO.createSupplier(supplier);
        Response.Redirect("Confirmation.aspx");
    }
}
