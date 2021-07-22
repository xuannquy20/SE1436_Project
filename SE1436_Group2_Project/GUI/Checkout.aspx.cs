using Lab3_Template.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Insert(0, new ListItem("Yêu cầu checkout", "0"));
                DropDownList1.Items.Insert(1, new ListItem("Checkout phòng đặt off", "1"));
                bind();
            }
        }

        public void bind()
        {
            String sql = "select r.idbook as 'Mã đặt', l.room as 'Phòng', username as 'Người đặt', dateend as 'Ngày trả' from requestCheckout r join listBook l on r.idbook = l.room";
            GridView1.DataSource = DAO.GetDataTable(sql);
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                String sql = "select r.idbook as 'Mã đặt', l.room as 'Phòng', username as 'Người đặt', dateend as 'Ngày trả' from requestCheckout r join listBook l on r.idbook = l.room";
                GridView1.DataSource = DAO.GetDataTable(sql);
                GridView1.DataBind();
            }
            else
            {
                String sql = "select id as 'Mã đặt', room as 'Phòng', name as 'Người đặt', dateend as 'Hạn phòng' from bookOff";
                GridView1.DataSource = DAO.GetDataTable(sql);
                GridView1.DataBind();
            }
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].ForeColor = System.Drawing.Color.Red;
            e.Row.Cells[3].Text = DateTime.Parse(e.Row.Cells[3].Text).ToShortDateString();
            if (e.Row.RowType == DataControlRowType.Header)
            {
                TableCellCollection obj = ((System.Web.UI.WebControls.TableRow)(e.Row)).Cells;
                TableCell cell = new TableCell();
                Label lbl = new Label();
                lbl.Text = "Lựa chọn";
                cell.Controls.Add(lbl);
                obj.Add(cell);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableCellCollection obj = ((System.Web.UI.WebControls.TableRow)(e.Row)).Cells;
                TableCell cell = new TableCell();
                HyperLink hyl = new HyperLink();
                hyl.Text = "Check out";
                hyl.NavigateUrl = "checkoutroom.aspx?id=" + e.Row.Cells[0].Text;
                cell.Controls.Add(hyl);
                obj.Add(cell);
            }
        }
    }
}