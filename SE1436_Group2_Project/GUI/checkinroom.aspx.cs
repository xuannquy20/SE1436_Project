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
    public partial class checkinroom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string room = Request.QueryString["room"];
            SqlCommand up = new SqlCommand("UPDATE [csProject].[dbo].[room] SET [status] = 2 WHERE room = @r");
            up.Parameters.AddWithValue("@r", int.Parse(room));
            DAO.UpdateTable(up);
            SqlCommand ud = new SqlCommand("UPDATE [csProject].[dbo].[listBook] SET [status] = 1 WHERE id = @i");
            ud.Parameters.AddWithValue("@i", id);
            DAO.UpdateTable(ud);
            Response.Redirect("ListroomGUI.aspx");
        }
    }
}