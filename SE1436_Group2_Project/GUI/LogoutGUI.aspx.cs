using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class LogoutGUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session["name"] = null;
            Session["role"] = -1;
            Session["comment"] = 0;
            Session["commented"] = null;
            if (Request.Cookies["user"] != null)
            {
                Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["name"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["role"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["comment"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["commented"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Trangchu.aspx");
        }
    }
}