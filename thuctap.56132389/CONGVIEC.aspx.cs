using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CONGVIEC : System.Web.UI.Page
{
    private static string connStr = "Data Source=VUHOAIDAVI;Initial Catalog=thuctap_56132389;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {
        HienThiGridView();
    }
    void HienThiGridView()
    {
        GVCV.DataSource = Lop_DS();
        GVCV.DataBind();
    }
    public DataTable Lop_DS()
    {
        DataTable table = new DataTable();
        SqlConnection connection = new SqlConnection(connStr);
        SqlDataAdapter adapter = new SqlDataAdapter("SV_CV_DS", connection);
        adapter.Fill(table);
        return table;
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        string mssv = txtmssv.Text;
        string mcv = txtmcv.Text;


        string ngaybd = txtngaybd.Text;
        string ngaykt = txtngaykt.Text;
        string kq = txtkq.Text;

        CONGVIEC_THEM(mssv, mcv , ngaybd, ngaykt, kq);

        HienThiGridView();
    }
    void CONGVIEC_THEM(string mssv, string mcv, string ngaybd, string ngaykt, string kq)
    {
        using (SqlConnection connection = new SqlConnection(connStr))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SV_CV_THEM", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MSSV", SqlDbType.VarChar).Value = mssv;
            command.Parameters.Add("@MACONGVIEC", SqlDbType.VarChar).Value = mcv;
            command.Parameters.Add("@NGAYBD", SqlDbType.DateTime).Value = ngaybd;
            command.Parameters.Add("@NGAYKT", SqlDbType.DateTime).Value = ngaykt;
            command.Parameters.Add("@KETQUA", SqlDbType.NVarChar).Value = kq;

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
    protected void btnsua_Click(object sender, EventArgs e)
    {
        string mssv = txtmssv.Text;
        string mcv = txtmcv.Text;


        string ngaybd = txtngaybd.Text;
        string ngaykt = txtngaykt.Text;
        string kq = txtkq.Text;

        CONGVIEC_SUA(mssv, mcv, ngaybd, ngaykt, kq);

        HienThiGridView();
    }
    public int CONGVIEC_SUA(string mssv, string mcv, string ngaybd, string ngaykt, string kq)
    {
        using (SqlConnection connection = new SqlConnection(connStr))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SV_CV_SUA", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MSSV", SqlDbType.VarChar).Value = mssv;
            command.Parameters.Add("@MACONGVIEC", SqlDbType.VarChar).Value = mcv;
            command.Parameters.Add("@NGAYBD", SqlDbType.DateTime).Value = ngaybd;
            command.Parameters.Add("@NGAYKT", SqlDbType.DateTime).Value = ngaykt;
            command.Parameters.Add("@KETQUA", SqlDbType.NVarChar).Value = kq;

            int result = command.ExecuteNonQuery();
            return result;

        }
    }
    protected void btnXoa_Click(object sender, EventArgs e)
    {

        string mssv = txtmssv.Text;
        string mcv = txtmcv.Text;
        string ngaybd = txtngaybd.Text;
        CONGVIEC_XOA(mssv,mcv,ngaybd);
        HienThiGridView();
    }
    public int CONGVIEC_XOA(string mssv,string mcv, string ngaybd)
    {
        using (SqlConnection connection = new SqlConnection(connStr))
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SV_CV_XOA", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MSSV", SqlDbType.VarChar).Value = mssv;
            command.Parameters.Add("@MACONGVIEC", SqlDbType.VarChar).Value = mcv;
            command.Parameters.Add("@NGAYBD", SqlDbType.DateTime).Value = ngaybd;
            int result = command.ExecuteNonQuery();
            return result;

        }
    }
}