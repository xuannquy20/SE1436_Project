using Lab3_Template.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class deletebook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            SqlCommand cmd = new SqlCommand("DELETE FROM [csProject].[dbo].[listBook] WHERE id = @i");
            cmd.Parameters.AddWithValue("@i", id);
            DAO.UpdateTable(cmd);
            Response.Redirect("HistoryBook.aspx");
        }
    }
}