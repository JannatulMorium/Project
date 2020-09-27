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

public partial class UI_AddEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Employee employee = new Employee();
        //employee.EmployeeID = Convert.ToInt32(txtId.Text);
        employee.Password = txtPassword.Text;
        employee.Name = txtName.Text;
        employee.Address = txtAddress.Text;
        employee.Phone = txtPhone.Text;
        employee.Cell = txtCell.Text;
        employee.Role = lstRole.SelectedValue;
        employee.Salary = Convert.ToDouble(txtSalary.Text);
        employee.ManagerID = Convert.ToInt32(lstManager.SelectedValue);
        EmployeeDAO.createEmployee(employee);
        Response.Redirect("Confirmation.aspx");
    }
}
