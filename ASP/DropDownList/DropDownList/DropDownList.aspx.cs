using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetPriceByName(string name)
        {
            string con = "Data Source=DESKTOP-DOUQUL8; initial catalog=stationery; integrated security=true;";
            SqlConnection connection = new SqlConnection(con);
            SqlDataAdapter sda = new SqlDataAdapter("getstore", connection);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@pname";
            param.Value = Productname;
            sda.SelectCommand.Parameters.Add(param);
            DataSet ds= new DataSet();
            sda.Fill(ds);
            GridView1.DataSource= ds;
            GridView1.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Image1.ImageUrl = "~/Images/" + DropDownList1.SelectedValue + ".JFIF";
            GetPriceByName(DropDownList1.SelectedValue);
            Label1.Text = this.GridView1.Rows[0].Cells[0].Text;
        }
    }
}