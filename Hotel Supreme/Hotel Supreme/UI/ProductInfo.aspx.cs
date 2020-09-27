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

public partial class UI_ProductInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string productID = Request.QueryString["ProductID"];

            if (productID != null)
                populateProductData(productID);

        }
    }

    private void populateProductData(string productID)
    {
        Product product = ProductDAO.getProduct(Convert.ToInt32(productID));
        lblProductID.Text = product.ProductID.ToString();
        txtName.Text = product.Name;
        txtQuantity.Text = product.Quantity.ToString();
        txtUnitPrice.Text = product.UnitPrice.ToString();
        lstSupplier.SelectedValue = product.SupplierID.ToString();
        txtDescription.Text = product.Description;

    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        Product product = new Product();
        product.ProductID = Convert.ToInt32(lblProductID.Text);
        product.Name = txtName.Text;
        product.Quantity = Convert.ToInt32(txtQuantity.Text);
        product.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
        product.SupplierID = Convert.ToInt32(lstSupplier.SelectedValue);
        product.Description = txtDescription.Text;
        ProductDAO.updateProduct(product);
        Response.Redirect("Confirmation.aspx");
    }
    protected void cmdDelete_Click(object sender, EventArgs e)
    {
        int productId = Convert.ToInt32(lblProductID.Text);
        ProductDAO.deleteProduct(productId);
        Response.Redirect("Confirmation.aspx");
    }
}
