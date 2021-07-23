<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Datphongthanhcong.aspx.cs" Inherits="SE1436_Group2_Project.GUI.Datphongthanhcong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       .lb{
          display: flex;
          align-item: center;
          width: 100%;
          height: auto;
       }
       .lbt{
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="lb">
        <asp:Label ID="Label1" runat="server" Text="Bạn đã đặt phòng thành công" CssClass="text-uppercase font-weight-bold lbt"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Mã đặt phòng của bạn là: " CssClass="text-uppercase font-weight-bold lbt"></asp:Label>
        </div>
</asp:Content>
