using Lab3_Template.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class AllFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "select name, liked, feedback from Account where feedback != 'null'";
            DataTable d = DAO.GetDataTable(sql);
            foreach (DataRow r in d.Rows)
            {
                Label user = new Label();
                Image i = new Image();
                Label content = new Label();
                user.Text = r["name"].ToString() + "<br/>";
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
        }

    }
}