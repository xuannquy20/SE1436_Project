<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Datphongthanhcong.aspx.cs" Inherits="SE1436_Group2_Project.GUI.Datphongthanhcong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Label1{
            margin-left: 500px;
            font-size: 40px;
        }
        #Label2{
            margin-left: 600px;
            font-size: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Bạn đã đặt phòng thành công "></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Mã đặt phòng của bạn là: "></asp:Label>
    </p>
</asp:Content>
