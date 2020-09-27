
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
using System.Data.SqlClient;



namespace DAO
{

    public class EmployeeDAO : BaseDAO
    {
        private EmployeeDAO()
        {

        }

        public static void createEmployee(Employee employee)
        {
            
            string query = null;
            
            if (employee.ManagerID == 0)
                query = "INSERT INTO Employee VALUES (@Name, @Address, @Phone,null, @Role,@Cell, @Password,@Salary )";
            else
                query = "INSERT INTO Employee VALUES (@Name, @Address, @Phone, @ManagerId, @Role,@Cell, @Password,@Salary )";
            
            SqlCommand command = new SqlCommand(query);
            //command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            command.Parameters.AddWithValue("@Password", employee.Password);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@Address", employee.Address);
            command.Parameters.AddWithValue("@Phone", employee.Phone);
            command.Parameters.AddWithValue("@Role", employee.Role);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            
            if (employee.ManagerID != 0)
                command.Parameters.AddWithValue("@ManagerID", employee.ManagerID);
            command.Parameters.AddWithValue("@Cell", employee.Cell);
            executeNonQuery(command);
        }

        public static void updateEmployee(Employee employee)
        {
            string query = null;
            
            if (employee.ManagerID == 0)
                query = "UPDATE Employee SET Name = @Name, Address = @Address, Phone = @Phone, ManagerId = null, JobId = @JobId, Cell = @Cell, Password = @Password, Salary = @Salary WHERE EmployeeID = @EmployeeID";
            else
                query = "UPDATE Employee SET Name = @Name, Address = @Address, Phone = @Phone, ManagerId = @ManagerId, JobId = @JobId, Cell = @Cell, Password = @Password, Salary = @Salary WHERE EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            command.Parameters.AddWithValue("@Name", employee.Name);
            command.Parameters.AddWithValue("@Address", employee.Address);
            command.Parameters.AddWithValue("@Phone", employee.Phone);
            if (employee.ManagerID != 0)
                command.Parameters.AddWithValue("@ManagerID", employee.ManagerID);
            command.Parameters.AddWithValue("@JobId", employee.Role);
            command.Parameters.AddWithValue("@Cell", employee.Cell);
            command.Parameters.AddWithValue("@Password", employee.Password);
            command.Parameters.AddWithValue("@Salary", employee.Salary);
            executeNonQuery(command);
        }


        public static DataTable getEmployeeList()
        {
            string query = "SELECT EmployeeID, Password, Name, Address, Phone, Role FROM Employee,JobTitle Where Employee.JobId = JobTitle.JobId";
            SqlCommand command = new SqlCommand(query);
            return executeQuery(command);
        }

       

        public static DataTable getSupervisedEmployeeList(int managerId)
        {
            string query = "SELECT EmployeeID, Password, Name, Address, Phone, Role FROM Employee, JobTitle Where Employee.ManagerId = @ManagerId and Employee.JobId = JobTitle.JobId";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ManagerId", managerId);
            return executeQuery(command);
        }

        public static DataTable getEmployeeListByJobId(int jobId)
        {
            string query = "SELECT EmployeeID, Password, Name, Address, Phone, Role FROM Employee,JobTitle Where Employee.JobId = JobTitle.JobId and Employee.JobId=@JobID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@JobId", jobId);
            return executeQuery(command);
        }

        public static bool authenticateEmployee(Employee employee)
        {
            string query = "SELECT EmployeeID FROM Employee WHERE EmployeeID = @EmployeeID AND Password = @Password";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            command.Parameters.AddWithValue("@Password", employee.Password);
            DataTable dataTable = executeQuery(command);

            if (dataTable.Rows.Count > 0)
                return true;

            return false;
        }

        public static Employee getEmployee(int employeeID)
        {
            string query = "SELECT EmployeeID, Name, Address, Phone, JobId, Salary, ManagerId, Cell, Password FROM Employee WHERE Employee.EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@EmployeeID", employeeID);
            DataTable dataTable = executeQuery(command);
            Employee employee = new Employee();
            employee.EmployeeID = Convert.ToInt32(dataTable.Rows[0]["EmployeeID"].ToString());
            employee.Name = dataTable.Rows[0]["Name"].ToString();
            employee.Address = dataTable.Rows[0]["Address"].ToString();
            employee.Phone = dataTable.Rows[0]["Phone"].ToString();
            employee.Role = dataTable.Rows[0]["JobId"].ToString();
            employee.Cell = dataTable.Rows[0]["Cell"].ToString();
            employee.Password = dataTable.Rows[0]["Password"].ToString();
            if (Convert.IsDBNull(dataTable.Rows[0]["ManagerID"]))
                employee.ManagerID = 0;
            else
                employee.ManagerID = Convert.ToInt32(dataTable.Rows[0]["ManagerID"].ToString());
            employee.Salary = Convert.ToDouble(dataTable.Rows[0]["Salary"]);
            //product.ImageName = dataTable.Rows[0]["ImageName"].ToString();
            //product.ListPrice = Convert.ToDouble(dataTable.Rows[0]["ListPrice"]);
            return employee;
        }


    }


}

