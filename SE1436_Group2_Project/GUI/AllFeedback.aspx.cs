using Lab3_Template.DAL;
using System;
using System.Collections.Generic;
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
            string sql = "select username, liked, content from feedback";
            GridView1.DataSource = DAO.GetDataTable(sql);
            GridView1.DataBind();
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.Cells[1].Text == "LIKE")
                {
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
    }
}