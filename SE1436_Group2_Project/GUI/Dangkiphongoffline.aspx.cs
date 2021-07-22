using Lab3_Template.DAL;
using SE1436_Group2_Project.DTL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE1436_Group2_Project.GUI
{
    public partial class Dangkiphongoffline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                floor.SelectedIndex = 0;
                getFloor();
                floor.DataBind();
                getRoom();
                room.DataBind();
                String type = Request.QueryString["hang"];
                if(type == "1")
                {
                    Image1.ImageUrl = "/Images/room1.png";
                }
                else if (type == "2")
                {
                    Image1.ImageUrl = "/Images/room2.png";
                }
                else if (type == "3")
                {
                    Image1.ImageUrl = "/Images/room3.png";
                }
            }
        }

        public void getFloor()
        {
            String type = Request.QueryString["hang"];
            String sql = "select distinct [floor] from room where [type] = " + type;
            floor.DataSource = DAO.GetDataTable(sql);
            floor.DataTextField = "floor";
            floor.DataValueField = "floor";
            
        }

        public void getRoom()
        {
            String sql = "select room from room where [floor] =" + floor.SelectedValue + " and status = 0";
            room.DataSource = DAO.GetDataTable(sql);
            room.DataTextField = "room";
            room.DataValueField = "room";
            room.DataBind();
        }

        protected void floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            getRoom();
        }

        public void InsertBookOffline()
        {
            String dateIn = checkIn.SelectedDate.ToString();
            String dateOut = checkOut.SelectedDate.ToString();
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[bookOff]([name],[sdt],[room],[datebook],[dateend],[people])"
                        +"VALUES(@name, @phone, @room, @dateIn , @dateOut, @people)");
            cmd.Parameters.AddWithValue("@name",name.Text);
            cmd.Parameters.AddWithValue("@phone", phonenumber.Text);
            cmd.Parameters.AddWithValue("@dateIn", dateIn);
            cmd.Parameters.AddWithValue("@dateOut", dateOut);
            cmd.Parameters.AddWithValue("@people", human.Text);
            DAO.UpdateTable(cmd);
        }

        public void UpdateStatus()
        {
            SqlCommand cmd = new SqlCommand("UPDATE[dbo].[room] SET[status] = 1"+"WHERE room = @room");
            cmd.Parameters.AddWithValue("@room", room.SelectedValue);
            DAO.UpdateTable(cmd);
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertBookOffline();
            UpdateStatus();
            Response.Redirect("Datphongthanhcong.aspx?room="+room.SelectedValue);
        }
    }
}