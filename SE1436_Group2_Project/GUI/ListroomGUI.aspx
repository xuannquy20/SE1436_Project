﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListroomGUI.aspx.cs" Inherits="SE1436_Group2_Project.GUI.ListroomGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-fb">
        <div class="div-feed">
            <asp:Panel ID="Panel1" runat="server" CssClass="box-fb">
                <asp:DropDownList ID="DropDownList1" CssClass="btn-block" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                <asp:GridView ID="GridView1" runat="server" Width="503px" OnRowDataBound="GridView1_RowDataBound">
                </asp:GridView>
            </asp:Panel>
        </div>
    </div>
</asp:Content>