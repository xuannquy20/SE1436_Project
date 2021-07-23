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
	public partial class checkoutroom : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string id = Request.QueryString["id"];
			string room = Request.QueryString["room"];
			SqlCommand udroom = new SqlCommand("UPDATE [csProject].[dbo].[room] SET [status] = 0 WHERE room = @r");
			udroom.Parameters.AddWithValue("@r", int.Parse(room));
			DAO.UpdateTable(udroom);
			SqlCommand udlb = new SqlCommand("UPDATE [csProject].[dbo].[listBook] SET [status] = 2 WHERE id = @i");
			udlb.Parameters.AddWithValue("@i", int.Parse(id));
			DAO.UpdateTable(udlb);
			SqlCommand cmd = new SqlCommand("UPDATE [csProject].[dbo].[requestCheckout] SET [status] = 1 WHERE idbook = @i");
			cmd.Parameters.AddWithValue("@i", id);
			DAO.UpdateTable(cmd);
			Response.Redirect("../Checkout.aspx");
		}
	}
}