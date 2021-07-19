<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AllFeedback.aspx.cs" Inherits="SE1436_Group2_Project.GUI.AllFeedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-fb">
        <div class="div-feed">
            <asp:Panel ID="Panel1" runat="server" CssClass="box-fb">
                <asp:GridView ID="GridView1" runat="server" BorderStyle="None" CellPadding="4" CellSpacing="10" EnableModelValidation="True" ForeColor="#333333" GridLines="Horizontal" ShowHeader="False" Width="503px" OnDataBound="GridView1_DataBound">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>

            </asp:Panel >
        </div>
    </div>
</asp:Content>
