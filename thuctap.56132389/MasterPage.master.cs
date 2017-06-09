using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class MasterPage : System.Web.UI.MasterPage
{
    string connStr = "Data Source=(local);Initial Catalog=thuctap_56132389;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(connStr);
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM MenuHeThong ORDER BY Menu", conn);
        SqlDataReader reader;
        string str = "";
        lblMeNu.Text = "<br/>";
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            str = string.Format("<a href=" + reader["LinkWeb"] + ">{0}</a><br/><hr/>", reader["Menu"]);

            lblMeNu.Text = lblMeNu.Text + str;
        }
    }
}
