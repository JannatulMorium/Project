
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
				using System.Data.SqlClient;
				using Model;

 

namespace DAO
{
    
    public class ProductDAO : BaseDAO
    {
                private ProductDAO()
        {

        }

        public static DataTable getSupplierList()
        {
            string query = "SELECT SupplierID, Name FROM Supplier";
            SqlCommand command = new SqlCommand(query);
            return executeQuery(command);
        }

        public static void deleteProduct(int productID)
        {
            string query = "DELETE FROM Product WHERE ProductID = @ProductId";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ProductId", productID);
            executeNonQuery(command);
        }

        public static void createProduct(Product product)
        {
            string query = "INSERT INTO Product VALUES (@Name, @SupplierID, @UnitPrice, @Description, @Quantity )";
            SqlCommand command = new SqlCommand(query);
            //command.Parameters.AddWithValue("@ProductID", product.ProductID);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@SupplierID", product.SupplierID);
            command.Parameters.AddWithValue("@Quantity", product.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            executeNonQuery(command);
        }

        public static void updateProduct(Product product)
        {
            string query = "UPDATE Product SET Name = @Name, Description = @Description, SupplierID = @SupplierID, Quantity = @Quantity, UnitPrice = @UnitPrice WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ProductID", product.ProductID);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@SupplierID", product.SupplierID);
            command.Parameters.AddWithValue("@Quantity", product.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            executeNonQuery(command);
        }

        public static DataTable getProductsList()
        {
            string query = "SELECT A.ProductID, A.Name, B.Name AS SupplierName, A.Quantity, A.UnitPrice FROM Product A, Supplier B WHERE A.SupplierID = B.SupplierID";
            SqlCommand command = new SqlCommand(query);
            return executeQuery(command);
        }

        public static DataTable getProductsListBySupplierID(int supplierID)
        {
            string query = "SELECT Name, ProductID, Quantity, UnitPrice FROM Product WHERE SupplierID = @SupplierID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@SupplierID", supplierID);
            return executeQuery(command);
        }

        public static Product getProduct(int productID)
        {
            string query = "SELECT ProductID, Name, Description, SupplierID, Quantity, UnitPrice FROM Product WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ProductID", productID);
            DataTable dataTable = executeQuery(command);
            Product product = new Product();
            product.ProductID = Convert.ToInt32(dataTable.Rows[0]["ProductID"]);
            product.Name = dataTable.Rows[0]["Name"].ToString();
            product.Description = dataTable.Rows[0]["Description"].ToString();
            product.SupplierID = Convert.ToInt32(dataTable.Rows[0]["SupplierID"].ToString());
            product.Quantity = Convert.ToInt32(dataTable.Rows[0]["Quantity"]);
            product.UnitPrice = Convert.ToDouble(dataTable.Rows[0]["UnitPrice"]);
            return product;
        }
    	
    }
    
  
 }
	
