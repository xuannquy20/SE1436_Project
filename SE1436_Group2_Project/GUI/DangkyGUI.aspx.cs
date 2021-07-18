using Lab3_Template.DAL;
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
    public partial class DangkyGUI : System.Web.UI.Page
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
                Label1.Visible = true;
                txtUsername.Text = "";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [csProject].[dbo].[Account]([username] ,[password] ,[isStaff]) VALUES (@u ,@p , 0)");
                cmd.Parameters.AddWithValue("@u",txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                DAO.UpdateTable(cmd);
                Response.Redirect("LoginGUI.aspx");
            }
        }
    }
}