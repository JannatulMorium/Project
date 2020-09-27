using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Web.Configuration;
using DAO;

public partial class Reservation : System.Web.UI.Page
{
//    private SqlConnection dbConn;
    private void findRooms()
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation");
//        cmd.Connection = dbConn;
//        dbConn.Open();
        SqlDataReader r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
        bool b = !r1.HasRows;
//        dbConn.Close();
        if (b)
        {
            cmd = new SqlCommand("SELECT RoomType.RoomType FROM RoomType INNER JOIN Room ON ROOM.RoomTypeID=RoomType.RoomTypeID ORDER BY RoomType.RoomType");
  //          cmd.Connection = dbConn;
  //          dbConn.Open();
            r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
            DropDownList1.Items.Clear();
            while (r1.Read())
            {
                if (!DropDownList1.Items.Contains(new ListItem(r1["RoomType"].ToString())))
                {
                    DropDownList1.Items.Add(r1["RoomType"].ToString());
                }
            }
//            dbConn.Close();
        }
        else
        {
            cmd = new SqlCommand("SELECT RoomType.RoomType FROM RoomType INNER JOIN (ROOM INNER JOIN RESERVATION ON ROOM.RoomID!=RESERVATION.RoomID) ON ROOM.RoomTypeID=RoomType.RoomTypeID ORDER BY RoomType.RoomType");
  //          cmd.Connection = dbConn;
  //          dbConn.Open();
            r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
            DropDownList1.Items.Clear();
            while (r1.Read())
            {
                if (!DropDownList1.Items.Contains(new ListItem(r1["RoomType"].ToString())))
                {
                    DropDownList1.Items.Add(r1["RoomType"].ToString());
                }
            }
//            dbConn.Close();
        }
        findRoomNumbers();
    }
    private void reset()
    {
        //Reset Room Information
        TextBox2.Text = "";
        Calendar1.SelectedDate = Calendar1.TodaysDate;
        Calendar2.SelectedDate = Calendar2.TodaysDate;
        //Reset DropDownMenus
        findRooms();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
/*        Configuration webConfiguration = WebConfigurationManager.OpenWebConfiguration("/HMS");
        ConnectionStringSettings connectionStringSettings =
        webConfiguration.ConnectionStrings.ConnectionStrings["HMSConnectionString"];
        string connectionString = connectionStringSettings.ConnectionString;
        dbConn = new SqlConnection(connectionString);*/
//        bd = new BaseDAO();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        reset();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string myQuery = "INSERT INTO Reservation (CustomerId, RoomId, EmployeeId, StartDate, EndDate, Booking_Charges) VALUES(" + DropDownList3.SelectedValue + ", " + DropDownList2.SelectedValue + ", " + "1" + ", " + Calendar1.SelectedDate.ToShortDateString() + ", " + Calendar2.SelectedDate.ToShortDateString() + ", " + TextBox2.Text + ")";
        SqlCommand myCommand =new SqlCommand(myQuery);
//        myCommand.Connection = dbConn;
//        dbConn.Open();
        SqlDataReader reader = BaseDAO.ExecuteReader(myCommand);//myCommand.ExecuteReader();
//        dbConn.Close();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        findRooms();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        findRoomNumbers();
    }
    private void findRoomNumbers()
    {
        SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation");
//        cmd.Connection = dbConn;
//        dbConn.Open();
        SqlDataReader r1 =BaseDAO.ExecuteReader(cmd);// cmd.ExecuteReader();
        bool b = !r1.HasRows;
//        dbConn.Close();
        if (b)
        {
            cmd = new SqlCommand("SELECT Room.RoomID, RoomType.RoomType FROM (RoomType INNER JOIN Room ON Room.RoomTypeID=RoomType.RoomTypeID)");
//            cmd.Connection = dbConn;
//            dbConn.Open();
            r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
            DropDownList2.Items.Clear();
            while (r1.Read())
            {
                if (r1["RoomType"].ToString() == DropDownList1.SelectedValue && !DropDownList2.Items.Contains(new ListItem(r1["RoomID"].ToString())))
                {
                    DropDownList2.Items.Add(r1["RoomID"].ToString());
                }
            }
//            dbConn.Close();
        }
        else
        {
            cmd = new SqlCommand("SELECT Room.RoomID, RoomType.RoomType FROM RoomType INNER JOIN(Room INNER JOIN Reservation ON Room.RoomID!=Reservation.RoomID) ON Room.RoomTypeID=RoomType.RoomTypeID ORDER BY Room.RoomID");
//            cmd.Connection = dbConn;
//            dbConn.Open();
            r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
            DropDownList2.Items.Clear();
            while (r1.Read())
            {
                if (r1["RoomType"].ToString() == DropDownList1.SelectedValue && !DropDownList2.Items.Contains(new ListItem(r1["RoomID"].ToString())))
                {
                    DropDownList2.Items.Add(r1["RoomID"].ToString());
                }
            }
//            dbConn.Close();
        }
        cmd = new SqlCommand("SELECT Room.Room_Price FROM Room WHERE Room.RoomID=" + DropDownList2.SelectedValue);
//        cmd.Connection = dbConn;
//        dbConn.Open();
        r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
        r1.Read();
        TextBox2.Text = r1["Room_Price"].ToString();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("SELECT RoomType.RoomType FROM (Room INNER JOIN RoomType ON Room.RoomTypeID=RoomType.RoomTypeID)");
//        cmd.Connection = dbConn;
//        dbConn.Open();
        SqlDataReader r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
        r1.Read();
        DropDownList1.SelectedIndex=DropDownList1.Items.IndexOf(new ListItem(r1["RoomType"].ToString()));
//        dbConn.Close();
        cmd = new SqlCommand("SELECT Room.Room_Price FROM Room WHERE Room.RoomID=" + DropDownList2.SelectedValue);
//        cmd.Connection = dbConn;
//        dbConn.Open();
        r1 = BaseDAO.ExecuteReader(cmd);//cmd.ExecuteReader();
        r1.Read();
        TextBox2.Text = r1["Room_Price"].ToString();
    }
}
