
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
	
				using System.Data.SqlClient;
				using System.Data.Common;
				using System.Web.Configuration; 

namespace DAO
{
    
    public class BaseDAO
    {
                  private static string connectionString = null;

        protected BaseDAO()
        {
            
        }
        public static SqlDataReader ExecuteReader(SqlCommand command){
            if (connectionString == null)
            {
                Configuration webConfiguration = WebConfigurationManager.OpenWebConfiguration("/HMS");
                ConnectionStringSettings connectionStringSettings =
                webConfiguration.ConnectionStrings.ConnectionStrings["HMSConnectionString"];
                connectionString = connectionStringSettings.ConnectionString;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;

           try
            {
               connection.Open();
               SqlDataReader reader;
               reader=command.ExecuteReader();
               return reader;
            }
            finally
            {
                connection.Close();
            }
        }

        private static DataTable executeHelper(SqlCommand command, bool isNonQuery)
        {
            if (connectionString == null)
            {
                Configuration webConfiguration = WebConfigurationManager.OpenWebConfiguration("/HMS");
                ConnectionStringSettings connectionStringSettings =
                    webConfiguration.ConnectionStrings.ConnectionStrings["HMSConnectionString"];
                connectionString = connectionStringSettings.ConnectionString;
            }

            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;

           try
            {
                connection.Open();

                if (isNonQuery)
                {
                    command.ExecuteNonQuery();
                    return null;
                }
                else
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            finally
            {
                connection.Close();
            }
        }

        protected static void executeNonQuery(SqlCommand command)
        {
            executeHelper(command, true);
        }

        protected static DataTable executeQuery(SqlCommand command)
        {
            return executeHelper(command, false);
        }
    	
    }
    
  
 }
	
