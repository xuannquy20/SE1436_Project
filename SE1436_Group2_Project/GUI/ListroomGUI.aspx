<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListroomGUI.aspx.cs" Inherits="SE1436_Group2_Project.GUI.ListroomGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="div-feed">
            <asp:Panel ID="Panel1" runat="server">
                <asp:DropDownList ID="DropDownList1" CssClass="btn-block form-control ce" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="969px">
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" Text="Đặt phòng trực tiếp" Visible="False" Width="180px" CssClass="btn btn-success form-control bt-mgl" BorderColor="#FF0066" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="Smaller" Height="33px" OnClick="Button1_Click"/>
                <br />
                <asp:GridView ID="GridView1" runat="server" Width="971px" CssClass="table table-hover ce" OnRowDataBound="GridView1_RowDataBound" GridLines="Horizontal" HorizontalAlign="Justify">
                </asp:GridView>
            </asp:Panel>
        </div>
</asp:Content>
