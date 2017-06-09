using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DKMH : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HienThiGridView();
    }
    void HienThiGridView()
    {
        GVDKMH.DataSource = Lop_DS();
        GVDKMH.DataBind();
    }
    public DataTable Lop_DS()
    {
        DataTable table = new DataTable();
        SqlConnection connection = new SqlConnection(StaticClass.connStr);
        SqlDataAdapter adapter = new SqlDataAdapter("DANGKYMH_DS", connection);
        adapter.Fill(table);
        return table;
    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        string mamh = txtmamh.Text;
        string tenmh = txttenmh.Text;

        
        string mssv = txtmssv.Text;
        string hocky = txthocky.Text;
        
        DANGKYMH_THEM(mamh, tenmh, mssv, hocky);

        HienThiGridView();
    }
    void DANGKYMH_THEM(string mamh, string tenmh, string mssv, string hocky)
    {
        using (SqlConnection connection = new SqlConnection(StaticClass.connStr))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DANGKYMH_THEM", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = mamh;
            command.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = tenmh;
            command.Parameters.Add("@MSSV", SqlDbType.VarChar).Value = mssv;
            command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = hocky;
            
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        string mamh = txtmamh.Text;
        string tenmh = txttenmh.Text;


        string mssv = txtmssv.Text;
        string hocky = txthocky.Text;
        DANGKYMH_SUA(mamh, tenmh, mssv, hocky);

        HienThiGridView();
    }
    public int DANGKYMH_SUA(string mamh, string tenmh, string mssv, string hocky)
    {
        using (SqlConnection connection = new SqlConnection(StaticClass.connStr))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DANGKYMH_SUA", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = mamh;
            command.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = tenmh;
            command.Parameters.Add("@MSSV", SqlDbType.NVarChar).Value = mssv;
            command.Parameters.Add("@HOCKY", SqlDbType.NVarChar).Value = hocky;
           
            int result = command.ExecuteNonQuery();
            return result;

        }
    }

    protected void btnXoa_Click(object sender, EventArgs e)
    {
        string masach = txtmamh.Text;
        DANGKYMH_XOA(masach);
        HienThiGridView();
    }
    public int DANGKYMH_XOA(string mamh)
    {
        using (SqlConnection connection = new SqlConnection(StaticClass.connStr))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("DANGKYMH_XOA", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = mamh;
            int result = command.ExecuteNonQuery();
            return result;

        }
    }
}