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

public partial class UI_EmployeeInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string employeeID = Request.QueryString["EmployeeID"];

            if (employeeID != null)
            {
                //Response.Write("Debug: " + employeeID);
                populateEmployeeData(employeeID);
                Employee employee = EmployeeDAO.getEmployee(Convert.ToInt32(employeeID));
                //lstRole.SelectedValue = employee.Role;
                //Response.Write("Debug: " + employee.Role);
                if (employee.Role.CompareTo("1") == 0)
                    cmdSuper.Visible = true;
                   // Response.Write("Debug: " + lstRole.SelectedValue);
            }

        }
    }

    private void populateEmployeeData(string employeeID)
    {
        Employee employee = EmployeeDAO.getEmployee(Convert.ToInt32(employeeID));
        lblEmployeeID.Text = employee.EmployeeID.ToString();
        txtName.Text = employee.Name;
        txtAddress.Text = employee.Address;
        txtPhone.Text = employee.Phone;
        txtSalary.Text = employee.Salary.ToString();
        lstManager.SelectedValue = employee.ManagerID.ToString();
        lstRole.SelectedValue = employee.Role;
        //if (lstRole.SelectedValue == "1")
           // cmdDelete.Enabled = false;
        txtCell.Text = employee.Cell;
        txtPassword.Text = employee.Password;
        


    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        Employee employee = new Employee();
        employee.EmployeeID = Convert.ToInt32(lblEmployeeID.Text);
        employee.Password = txtPassword.Text;
        employee.Name = txtName.Text;
        employee.Address = txtAddress.Text;
        employee.Phone = txtPhone.Text;
        employee.Cell = txtCell.Text;
        employee.Role = lstRole.SelectedValue;
        employee.Salary = Convert.ToDouble(txtSalary.Text);
        employee.ManagerID = Convert.ToInt32(lstManager.SelectedValue);
        EmployeeDAO.updateEmployee(employee);
        Response.Redirect("Confirmation.aspx");
    }
    protected void cmdSuper_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupervisedEmployees.aspx?ManagerId=" + lblEmployeeID.Text);
    }
}
