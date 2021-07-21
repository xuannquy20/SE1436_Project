<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListroomGUI.aspx.cs" Inherits="SE1436_Group2_Project.GUI.ListroomGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-fb">
        <div class="div-feed">
            <asp:Panel ID="Panel1" runat="server" CssClass="box-fb">
                <asp:DropDownList ID="DropDownList1" CssClass="btn-block" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Đặt phòng trực tiếp" Visible="False" Width="180px" CssClass="btn btn-success" BorderColor="#FF0066" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="Smaller" Height="33px"/>
                <br />
                <asp:GridView ID="GridView1" runat="server" Width="503px" CssClass="table table-hover" OnRowDataBound="GridView1_RowDataBound" GridLines="Horizontal" HorizontalAlign="Justify">
                </asp:GridView>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
