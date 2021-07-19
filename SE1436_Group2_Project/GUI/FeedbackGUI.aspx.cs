using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class FeedbackGUI : System.Web.UI.Page
    {
        bool liked;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            liked = true;
            ImageButton1.BackColor = System.Drawing.Color.SkyBlue;
            ImageButton2.BackColor = System.Drawing.Color.White;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            liked = false;
            ImageButton1.BackColor = System.Drawing.Color.White;
            ImageButton2.BackColor = System.Drawing.Color.SkyBlue;
        }
    }
}