using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            disp_data();


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values('"+ FirstName.Text +"','"+ LastName.Text +"','"+ txtMobile.Text +"','"+ txtEmail.Text +"','"+ City.Text +"')";
            cmd.ExecuteNonQuery();

            FirstName.Text = "";
            LastName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            City.Text = "";

            disp_data();
        }


        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table1 ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from table1 where firstname='"+ FirstName.Text + "'";
            cmd.ExecuteNonQuery();
            FirstName.Text = "";
            disp_data();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update table1 set firstname='" + FirstName.Text + "',lastname='" + LastName.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "',city='" + City.Text + "' where id=" + Convert.ToInt32(id.Text) + "";
            cmd.ExecuteNonQuery();
            FirstName.Text = "";
            LastName.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            City.Text = "";

            disp_data();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}