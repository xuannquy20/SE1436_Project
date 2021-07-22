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
            SqlCommand cmd = new SqlCommand();
            if (DropDownList1.SelectedValue == "1" || DropDownList1.SelectedValue == "2") {
             cmd = new SqlCommand("select l.id as 'Mã đặt', l.room as 'Phòng', a.name as 'Người đặt', a.phone as 'Số điện thoại', l.datebook as 'Ngày ở', l.dateend as 'Ngày trả' from listBook l join room r on l.room = r.room join Account a on l.username = a.username where r.status = @s");
             cmd.Parameters.AddWithValue("@s", DropDownList1.SelectedValue);
            }
            else
            {
                cmd = new SqlCommand("select room as 'Phòng', [FLOOR] as 'Tầng', [type] as 'Hạng phòng' from room where [status] = 0");
            }
            GridView1.DataSource = DAO.GetDataTable(cmd);
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].ForeColor = System.Drawing.Color.Red;
            if (e.Row.RowType == DataControlRowType.DataRow && DropDownList1.SelectedValue == "0") { 
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
            
            if (e.Row.RowType == DataControlRowType.DataRow && DropDownList1.SelectedValue != "0")
            {
                e.Row.Cells[4].Text = DateTime.Parse(e.Row.Cells[4].Text).ToShortDateString();
                e.Row.Cells[5].Text = DateTime.Parse(e.Row.Cells[5].Text).ToShortDateString();
            }
            if (e.Row.RowType == DataControlRowType.Header && DropDownList1.SelectedValue.ToString() == "1")
            {
                TableCellCollection obj = ((System.Web.UI.WebControls.TableRow)(e.Row)).Cells;
                TableCell cell = new TableCell();
                Label lbl = new Label();
                lbl.Text = "Lựa chọn";
                cell.Controls.Add(lbl);
                obj.Add(cell);
            }
            if (e.Row.RowType == DataControlRowType.DataRow && DropDownList1.SelectedValue == "1")
            {
                TableCellCollection obj = ((System.Web.UI.WebControls.TableRow)(e.Row)).Cells;
                TableCell cell = new TableCell();
                HyperLink hyl = new HyperLink();
                hyl.Text = "Check in";
                hyl.NavigateUrl = "checkinroom.aspx?id=" + e.Row.Cells[0].Text+"&room="+e.Row.Cells[1].Text;
                cell.Controls.Add(hyl);
                obj.Add(cell);
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
            Response.Redirect("");
        }
    }
}