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
    public partial class FeedbackGUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if(!IsPostBack){ 
                if(Session["user"] != null) { 
                    if (Session["comment"].ToString() == "1")
                    {
                        string cmd = "select feedback, liked from Account where username = '" + Session["user"].ToString() + "'";
                        DataTable dt = DAO.GetDataTable(cmd);
                        DataRow dr = dt.Rows[0];
                        TextBox1.Text = dr["feedback"].ToString();
                        if(dr["liked"].ToString() == "1")
                        {
                            ImageButton1.BackColor = System.Drawing.Color.SkyBlue;
                        }
                        else
                        {
                            ImageButton2.BackColor = System.Drawing.Color.SkyBlue;
                        }
                        Button1.Text = "Sửa";
                        Button1.Enabled = true;
                    }
                }
            }
            string sql = "select top 3 name, liked, feedback from Account where feedback != 'null' order by datefb desc";
            DataTable d = DAO.GetDataTable(sql);
            foreach (DataRow r in d.Rows)
            {
                Label user = new Label();
                Image i = new Image();
                Label content = new Label();
                user.Text = r["name"].ToString() + " ";
                if (r["liked"].ToString() == "1")
                {
                    i.ImageUrl = "../Images/like.png";
                }
                else
                {
                    i.ImageUrl = "../Images/dislike.png";
                }
                content.Text = "<br/>" + r["feedback"].ToString() + "<br/>" + "________________________________________________________________" + "<br/>";
                user.Font.Bold = true;
                i.Width = 20;
                Panel1.Controls.Add(user);
                Panel1.Controls.Add(i);
                Panel1.Controls.Add(content);
            }
            HyperLink lb = new HyperLink();
            lb.Text = "Nhấn để xem tất cả bình luận>>>";
            lb.NavigateUrl = "AllFeedback.aspx";
            Panel1.Controls.Add(lb);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Button1.Enabled = true;
            ImageButton1.BackColor = System.Drawing.Color.SkyBlue;
            ImageButton2.BackColor = System.Drawing.Color.White;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Button1.Enabled = true;
            ImageButton1.BackColor = System.Drawing.Color.White;
            ImageButton2.BackColor = System.Drawing.Color.SkyBlue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE [csProject].[dbo].[Account] SET [liked] = @l ,[feedback] = @c, datefb = @d WHERE username = @u");
                cmd.Parameters.AddWithValue("@u", Session["user"].ToString());
            cmd.Parameters.AddWithValue("@d", DateTime.Now);
                if (ImageButton1.BackColor == System.Drawing.Color.SkyBlue)
                {
                    cmd.Parameters.AddWithValue("@l", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@l", 2);
                }
                cmd.Parameters.AddWithValue("@c", TextBox1.Text);
            DAO.UpdateTable(cmd);
            Response.Redirect("FeedbackGUI.aspx");
        }
    }
}