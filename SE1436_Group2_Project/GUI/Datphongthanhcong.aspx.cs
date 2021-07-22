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
    public partial class Datphongthanhcong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable db = getList();
                DataRow room = db.Rows[db.Rows.Count-1];
                Label2.Text = Label2.Text + room["id"].ToString();
            }
        }

        public DataTable getList()
        {
            String sql = "select  * from listBook";
            return DAO.GetDataTable(sql);
        }
    }
}