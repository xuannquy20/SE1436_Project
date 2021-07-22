<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="SE1436_Group2_Project.GUI.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="div-feed">
            <asp:Panel ID="Panel1" runat="server" CssClass="box-fb">
                <asp:DropDownList ID="DropDownList1" CssClass="btn-block form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>

                <br />
                <asp:GridView ID="GridView1" runat="server" Width="505px" CssClass="table table-hover" OnRowDataBound="GridView1_RowDataBound" >
                </asp:GridView>

            </asp:Panel>
    </div>
</asp:Content>
