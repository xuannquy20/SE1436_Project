using Lab3_Template.DAL;
using SE1436_Group2_Project.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class LoginGUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("select * from account where username = @u and password = @p");
            sql.Parameters.AddWithValue("@u", txtUsername.Text);
            sql.Parameters.AddWithValue("@p", txtPassword.Text);
            DataTable dt = DAO.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                User u = new User
                {
                    Username = dr["username"].ToString(),
                    Role = int.Parse(dr["isStaff"].ToString())
                };
                Session["user"] = u.Username;
                Session["role"] = u.Role;
                Response.Redirect("Trangchu.aspx");
            }
            else
            {
                Label1.Visible = true;
            }
        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }
    }
}