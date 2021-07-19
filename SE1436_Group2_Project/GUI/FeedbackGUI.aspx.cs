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
                string sql = "select top 3 username, liked, content from feedback order by id desc";
                GridView1.DataSource = DAO.GetDataTable(sql);
                GridView1.DataBind();
                if (Session["commented"]!=null && Session["commented"].ToString() == "1")
                {
                string cmd = "select content from feedback where username = '" + Session["user"].ToString() + "'";
                DataTable dt = DAO.GetDataTable(cmd);
                DataRow dr = dt.Rows[0];
                TextBox1.Text = dr["content"].ToString();
                Button1.Text = "Sửa";
                }
            }
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

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if(row.Cells[1].Text == "LIKE") {
                    row.Cells[1].ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    row.Cells[1].ForeColor = System.Drawing.Color.DarkRed;
                }
                row.Cells[1].Font.Bold = true;
                row.Cells[1].Height = 100;
                row.Cells[0].Width = 80;
                row.Cells[1].Width = 80;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            if(Session["commented"].ToString() != "1") { 
                cmd = new SqlCommand("INSERT INTO [csProject].[dbo].[feedback]([username],[liked],[content]) VALUES (@u,@l,@c)");
                cmd.Parameters.AddWithValue("@u", Session["user"].ToString());
                if(ImageButton1.BackColor == System.Drawing.Color.SkyBlue) { 
                    cmd.Parameters.AddWithValue("@l", "LIKE");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@l", "DISLIKE");
                }
                cmd.Parameters.AddWithValue("@c", TextBox1.Text);
                Session["commented"] = 1;
            }
            else
            {
                cmd = new SqlCommand("UPDATE [csProject].[dbo].[feedback] SET [liked] = @l ,[content] = @c WHERE username = @u");
                cmd.Parameters.AddWithValue("@u", Session["user"].ToString());
                if (ImageButton1.BackColor == System.Drawing.Color.SkyBlue)
                {
                    cmd.Parameters.AddWithValue("@l", "LIKE");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@l", "DISLIKE");
                }
                cmd.Parameters.AddWithValue("@c", TextBox1.Text);
            }
            DAO.UpdateTable(cmd);
            Response.Redirect("FeedbackGUI.aspx");
        }
    }
}