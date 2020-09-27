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

public partial class UI_AddProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Product product = new Product();
        //product.ProductID = Convert.ToInt32(txtId.Text);
        product.Name = txtName.Text;
        product.Description = txtDescription.Text;
        product.Quantity = Convert.ToInt32(txtQuantity.Text);
        product.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
        product.SupplierID = Convert.ToInt32(lstSupplier.SelectedValue);
        ProductDAO.createProduct(product);
        Response.Redirect("Confirmation.aspx");
    }
}
