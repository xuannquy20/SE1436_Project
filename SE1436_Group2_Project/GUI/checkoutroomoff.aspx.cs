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
    public partial class checkoutroomoff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string room = Request.QueryString["room"];
            SqlCommand cmd = new SqlCommand("UPDATE [csProject].[dbo].[bookOff] SET [status] = 2 WHERE id = @i");
            cmd.Parameters.AddWithValue("@i", id);
            DAO.UpdateTable(cmd);
            SqlCommand sql = new SqlCommand("UPDATE [csProject].[dbo].[room] SET [status] = 0 WHERE room = @r");
            sql.Parameters.AddWithValue("@r", room);
            DAO.UpdateTable(sql);
            Response.Redirect("Checkout.aspx");
        }
    }
}