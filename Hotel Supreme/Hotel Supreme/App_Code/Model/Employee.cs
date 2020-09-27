
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


namespace Model
{

    public class Employee
    {
        private int _employeeID;
        private string _password;
        private string _name;
        private string _address;
        private string _phone;
        private string _role;
        private int _managerID;
        private double _salary;
        private string _cell;



        public Employee()
        {

        }

        public int EmployeeID
        {
            set { _employeeID = value; }
            get { return _employeeID; }
        }

        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        public string Phone
        {
            set { _cell = value; }
            get { return _cell; }
        }

        public string Cell
        {
            set { _phone = value; }
            get { return _phone; }
        }



        public string Role
        {
            set { _role = value; }
            get { return _role; }
        }

        public int ManagerID
        {
            set { _managerID = value; }
            get { return _managerID; }
            
        }

        public double Salary
        {
            set { _salary = value; }
            get { return _salary; }
        }

    }


}

