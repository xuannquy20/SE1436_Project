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
                    Role = int.Parse(dr["isStaff"].ToString()),
                    IsBooked = int.Parse(dr["isBooked"].ToString()),
                    Name = dr["name"].ToString(),
                    Phone = dr["phone"].ToString(),
                    CanComment = int.Parse(dr["canComment"].ToString()),
                    Commented = int.Parse(dr["commented"].ToString())
                };
                Session["user"] = u.Username;
                Session["role"] = u.Role;
                Session["comment"] = u.CanComment;
                Session["commented"] = u.Commented;
                if (CheckBox1.Checked)
                {
                    HttpCookie user = new HttpCookie("user");
                    user.Value = u.Username;
                    HttpCookie role = new HttpCookie("role");
                    role.Value = u.Role.ToString();
                    HttpCookie comment = new HttpCookie("comment");
                    comment.Value = u.CanComment.ToString();
                    HttpCookie commented = new HttpCookie("commented");
                    commented.Value = u.Commented.ToString();
                    user.Expires = DateTime.Now.AddYears(10);
                    role.Expires = DateTime.Now.AddYears(10);
                    comment.Expires = DateTime.Now.AddYears(10);
                    commented.Expires = DateTime.Now.AddYears(10);
                    Response.Cookies.Add(user);
                    Response.Cookies.Add(role);
                    Response.Cookies.Add(comment);
                    Response.Cookies.Add(commented);
                }
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DangkyGUI.aspx");
        }
    }
}