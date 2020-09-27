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

public partial class UI_SuppliedProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string supplierID = Request.QueryString["SupplierId"];

            if (supplierID != null)
            {
                populateProductData(Convert.ToInt32(supplierID));
                //if (lstRole.SelectedValue != "1")
                //cmdDelete.Enabled = false;
            }

        }
    }

    private void populateProductData(int id)
    {
        grdProducts.DataSource = ProductDAO.getProductsListBySupplierID(id);
        grdProducts.DataBind();
    }

    protected void grdProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("ProductInfo.aspx?ProductID=" +
        grdProducts.DataKeys[grdProducts.SelectedIndex].Value.ToString());
    }

}
