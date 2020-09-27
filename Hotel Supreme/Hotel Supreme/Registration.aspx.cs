using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Rayen\Web Dev\Shopping_cart\App_Data\shopping.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void b1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Registration values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"')";
        cmd.ExecuteNonQuery();
        
        con.Close();

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";

        l1.Text = "Registration Succesful";
    }
}