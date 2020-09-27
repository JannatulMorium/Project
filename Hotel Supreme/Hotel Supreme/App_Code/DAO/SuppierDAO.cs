
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

    public class SupplierDAO : BaseDAO
    {
        private SupplierDAO()
        {

        }

        public static void createSupplier(Supplier supplier)
        {
            string query = "INSERT INTO Supplier VALUES (@Name, @Address, @Phone ,@Cell)";
            SqlCommand command = new SqlCommand(query);
            //command.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
            command.Parameters.AddWithValue("@Name", supplier.Name);
            command.Parameters.AddWithValue("@Address", supplier.Address);
            command.Parameters.AddWithValue("@Phone", supplier.Phone);
            command.Parameters.AddWithValue("@Cell", supplier.Cell);
            executeNonQuery(command);
        }

        public static void updateSupplier(Supplier supplier)
        {
            string query = "UPDATE Supplier SET Name = @Name, Address = @Address, Phone = @Phone, Cell = @Cell WHERE SupplierID = @SupplierID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
            command.Parameters.AddWithValue("@Name", supplier.Name);
            command.Parameters.AddWithValue("@Address", supplier.Address);
            command.Parameters.AddWithValue("@Phone", supplier.Phone);
            command.Parameters.AddWithValue("@Cell", supplier.Cell);
            executeNonQuery(command);
        }


        public static DataTable getSupplierList()
        {
            string query = "SELECT SupplierID, Name, Address, Phone, Cell FROM SUPPLIER";
            SqlCommand command = new SqlCommand(query);
            return executeQuery(command);
        }



        public static Supplier getSupplier(int supplierID)
        {
            string query = "SELECT SupplierID, Name, Address, Phone, Cell FROM SUPPLIER WHERE SupplierID = @SupplierID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@SupplierID", supplierID);
            DataTable dataTable = executeQuery(command);
            Supplier supplier = new Supplier();
            supplier.SupplierID = Convert.ToInt32(dataTable.Rows[0]["SupplierID"].ToString());
            supplier.Name = dataTable.Rows[0]["Name"].ToString();
            supplier.Address = dataTable.Rows[0]["Address"].ToString();
            supplier.Phone = dataTable.Rows[0]["Phone"].ToString();
            supplier.Cell = dataTable.Rows[0]["Cell"].ToString();
            return supplier;
        }


    }


}

