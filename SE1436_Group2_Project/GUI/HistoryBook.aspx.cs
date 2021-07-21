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
    public partial class HistoryBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) { 
                DropDownList1.Items.Insert(0, new ListItem("Phòng đã đặt(chưa ở)", "0"));
                DropDownList1.Items.Insert(1, new ListItem("Phòng đang sử dụng", "1"));
                DropDownList1.Items.Insert(2, new ListItem("Phòng đã từng ở", "2"));
            }
            if (int.Parse(DropDownList1.SelectedValue) != 2)
            {
                SqlCommand sql = new SqlCommand("select id as 'Mã đặt', l.room as 'Phòng', people as 'Số người', datebook as 'Từ ngày', dateend as 'Đến ngày' from listBook l where username = @u and l.[status] = @s");
                sql.Parameters.AddWithValue("@s", DropDownList1.SelectedValue);
                sql.Parameters.AddWithValue("@u", Session["user"].ToString());
                GridView1.DataSource = DAO.GetDataTable(sql);
                GridView1.DataBind();
            }
            else
            {
                SqlCommand sql = new SqlCommand("select id as 'Mã đặt', l.room as 'Phòng', people as 'Số người', datebook as 'Từ ngày', dateend as 'Đến ngày' from listBook l where username = @u and l.[status] = 2");
                sql.Parameters.AddWithValue("@u", Session["user"].ToString());
                GridView1.DataSource = DAO.GetDataTable(sql);
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].ForeColor = System.Drawing.Color.Red;
            if (e.Row.RowType == DataControlRowType.Header && DropDownList1.SelectedValue != "3")
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
                hyl.Text = "Huỷ phòng";
                hyl.NavigateUrl = "deletebook.aspx?id=" + e.Row.Cells[0].Text;
                cell.Controls.Add(hyl);
                obj.Add(cell);
            }
            if (e.Row.RowType == DataControlRowType.DataRow && DropDownList1.SelectedValue == "2")
            {
                TableCellCollection obj = ((System.Web.UI.WebControls.TableRow)(e.Row)).Cells;
                TableCell cell = new TableCell();
                HyperLink hyl = new HyperLink();
                hyl.Text = "Check out";
                hyl.NavigateUrl = "checkoutbook.aspx?id=" + e.Row.Cells[0].Text + "&room=" + e.Row.Cells[1].Text;
                cell.Controls.Add(hyl);
                obj.Add(cell);
            }
        }

        private void Hyl_Click(object sender, EventArgs e)
        {
            string someString = ((Button)sender).Text.Substring(7);
            SqlCommand sql = new SqlCommand("DELETE FROM [csProject].[dbo].[listBook] WHERE id = @i");
            sql.Parameters.AddWithValue("@i", int.Parse(someString));
            DAO.UpdateTable(sql);
            Response.Redirect("HistoryBook.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
        }
    }
}