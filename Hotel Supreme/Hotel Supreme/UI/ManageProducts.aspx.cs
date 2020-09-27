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

public partial class UI_ManageProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            populateProductssGrid();
        }
    }

    private void populateProductssGrid()
    {
        grdProducts.DataSource = ProductDAO.getProductsList();
        grdProducts.DataBind();
    }

    protected void grdProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("ProductInfo.aspx?ProductID=" +
        grdProducts.DataKeys[grdProducts.SelectedIndex].Value.ToString());
    }


}
