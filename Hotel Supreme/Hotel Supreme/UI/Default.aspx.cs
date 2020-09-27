
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

using Model;
using DAO;

public partial class UI_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void loginControl_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Employee user = new Employee();
        user.EmployeeID = Convert.ToInt32(loginControl.UserName);
        user.Password = loginControl.Password;
        e.Authenticated = EmployeeDAO.authenticateEmployee(user);

       

        if (e.Authenticated)
        {
            Response.Redirect("DefaultSecure.aspx");
        }
    }


}


