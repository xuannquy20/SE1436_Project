using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                Image1.ImageUrl = "/Images/main1.jpg";
                if (Request.Cookies["user"] != null)
                {
                    Session["user"] = Request.Cookies["user"].Value.ToString();
                    Session["name"] = Request.Cookies["name"].Value.ToString();
                    Session["role"] = Request.Cookies["role"].Value.ToString();
                    Session["comment"] = Request.Cookies["comment"].Value.ToString();
                    Session["canComment"] = Request.Cookies["canComment"].Value.ToString();
                }
            }
        }
    }
}