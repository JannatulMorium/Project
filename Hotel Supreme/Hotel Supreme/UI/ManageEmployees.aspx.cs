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

public partial class UI_ManageEmployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            populateUsersGrid();
        }
    }

    private void populateUsersGrid()
    {
        grdEmployees.DataSource = EmployeeDAO.getEmployeeList();
        grdEmployees.DataBind();
    }

    protected void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeInfo.aspx?EmployeeID=" +
        grdEmployees.DataKeys[grdEmployees.SelectedIndex].Value.ToString());
    }
    protected void lnkCreateNewUser_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddEmployee.aspx");
    }

    protected void cmdMan_Click(object sender, EventArgs e)
    {
        //Response.Redirect("ViewManagers.aspx");
        grdEmployees.DataSource = EmployeeDAO.getEmployeeListByJobId(1);
        grdEmployees.DataBind();
    }
    protected void cmdRep_Click(object sender, EventArgs e)
    {
        grdEmployees.DataSource = EmployeeDAO.getEmployeeListByJobId(2);
        grdEmployees.DataBind();
    }
    protected void cmdMain_Click(object sender, EventArgs e)
    {
        grdEmployees.DataSource = EmployeeDAO.getEmployeeListByJobId(3);
        grdEmployees.DataBind();
    }
}
