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

public partial class UI_SupplierInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string supplierID = Request.QueryString["SupplierID"];

            if (supplierID != null)
                populateSupplierData(supplierID);

        }
    }

    private void populateSupplierData(string supplierID)
    {
        Supplier supplier = SupplierDAO.getSupplier(Convert.ToInt32(supplierID));
        lblSupplierID.Text = supplier.SupplierID.ToString();
        txtName.Text = supplier.Name;
        txtAddress.Text = supplier.Address;
        txtPhone.Text = supplier.Phone;
        txtCell.Text = supplier.Cell;

    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        Supplier supplier = new Supplier();
        supplier.SupplierID = Convert.ToInt32(lblSupplierID.Text);
        supplier.Name = txtName.Text;
        supplier.Address = txtAddress.Text;
        supplier.Phone = txtPhone.Text;
        supplier.Cell = txtCell.Text;
        SupplierDAO.updateSupplier(supplier);
        Response.Redirect("Confirmation.aspx");
    }
    protected void cmdProd_Click(object sender, EventArgs e)
    {
        Response.Redirect("SuppliedProducts.aspx?SupplierId=" + lblSupplierID.Text);
    }
}
