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
    public partial class ListroomGUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Insert(0, new ListItem("Phòng đã đặt(chưa ở)", "1"));
                DropDownList1.Items.Insert(1, new ListItem("Phòng đang sử dụng", "2"));
                DropDownList1.Items.Insert(2, new ListItem("Phòng trống", "0"));
            }
            SqlCommand cmd = new SqlCommand("select room as 'Phòng', [FLOOR] as 'Tầng', [type] as 'Hạng phòng' from room where [status] = @s");
            cmd.Parameters.AddWithValue("@s", DropDownList1.SelectedValue);
            GridView1.DataSource = DAO.GetDataTable(cmd);
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.Cells[2].Text == "1")
            {
                e.Row.Cells[2].Text = "Gường đơn";
            }
            if (e.Row.Cells[2].Text == "2")
            {
                e.Row.Cells[2].Text = "Giường đôi";
            }
            if (e.Row.Cells[2].Text == "3")
            {
                e.Row.Cells[2].Text = "VIP";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "0")
            {
                Button1.Visible = true;
            }
            else
            {
                Button1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}