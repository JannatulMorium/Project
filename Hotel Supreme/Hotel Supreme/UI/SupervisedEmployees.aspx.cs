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

public partial class UI_SupervisedEmployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string managerID = Request.QueryString["ManagerId"];

            if (managerID != null)
            {
                populateEmployeeData(Convert.ToInt32(managerID));
                //if (lstRole.SelectedValue != "1")
                //cmdDelete.Enabled = false;
            }

        }
    }

    private void populateEmployeeData(int id)
    {
        grdEmployees.DataSource = EmployeeDAO.getSupervisedEmployeeList(id);
        grdEmployees.DataBind();
    }

    protected void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeInfo.aspx?EmployeeID=" +
        grdEmployees.DataKeys[grdEmployees.SelectedIndex].Value.ToString());
    }
    
}
