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

public partial class UI_ManageSuppliers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            populateSuppliersGrid();
        }
    }

    private void populateSuppliersGrid()
    {
        grdSuppliers.DataSource = SupplierDAO.getSupplierList();
        grdSuppliers.DataBind();
    }

    protected void grdSuppliers_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("SupplierInfo.aspx?SupplierID=" +
        grdSuppliers.DataKeys[grdSuppliers.SelectedIndex].Value.ToString());
    }
   

}
