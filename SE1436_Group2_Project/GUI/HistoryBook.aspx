<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HistoryBook.aspx.cs" Inherits="SE1436_Group2_Project.GUI.HistoryBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-fb">
        <div class="div-feed">
            <asp:Panel ID="Panel1" runat="server" CssClass="box-fb">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="btn-secondary" AutoPostBack="True">
                </asp:DropDownList>
                <asp:GridView ID="GridView1" runat="server" BorderStyle="None" GridLines="Horizontal" OnRowDataBound="GridView1_RowDataBound" Width="502px">
                </asp:GridView>
            </asp:Panel>
            </div>
        </div>
</asp:Content>
