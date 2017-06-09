using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DANGNHAP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void btndangnhap_Click(object sender, EventArgs e)
    {
        StaticClass.mssv = txtMSSV.Text;
    }
}