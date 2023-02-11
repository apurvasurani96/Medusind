using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment_1
{
    public partial class DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        protected void GetData(string Pname)
        {
            string connectionString = "Data Source;initioal catalog=TrainingDB;integrated security=true;";
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter("product", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@pro";
            param.Value = Pname;
            da.SelectCommand.Parameters.Add(param);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = "~/images" + DropDownList2.SelectedValue + ".jpg";
            GetData(DropDownList2.SelectedValue);
            Label1.Text = GridView1.Rows[0].Cells[0].Text;
        }
       

    }
}