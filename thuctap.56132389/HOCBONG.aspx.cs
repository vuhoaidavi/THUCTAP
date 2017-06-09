using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HOCBONG : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
       
        string hocluc = hocLuc(StaticClass.mssv);
        if (StaticClass.mssv == null)
            return;

        if (hocluc.Equals("XUẤT SẮC"))
        {
            lblHocBong.Text = "2000000";
        }
        else if (hocluc.Equals("GIỎI"))
        {
            lblHocBong.Text = "1000000";
        }
        else if (hocluc.Equals("KHÁ"))
        {
            lblHocBong.Text = "50000000";
        }
        else
        {
            lblHocBong.Text = "Ngu nhu bo";
        }
    }

    string hocLuc(string mssv)
    {
        string hocluc = "";

        SqlConnection connection = new SqlConnection(StaticClass.connStr);
        connection.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM DANGSV WHERE MSSV = '" + mssv + "'", connection);
        SqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
           hocluc = reader.GetString(1);
        }

        return hocluc;     
    }
}