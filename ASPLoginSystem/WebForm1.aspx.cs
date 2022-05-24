using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPLoginSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection SQLconn = new SqlConnection("Data Source=MIKE; initial Catalog=ASPLogin; integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            messagelbl.Text = "";
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("SELECT * FROM useraccount WHERE UserName='"+ txtusername.Text + "' AND Password='" + txtpassword.Text + "'", SQLconn);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                messagelbl.Text = "You have successfully logged in";
                messagelbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                messagelbl.Text = "Invalid Username or Password";
                messagelbl.ForeColor = System.Drawing.Color.Red;
            }
                

        }

        protected void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}