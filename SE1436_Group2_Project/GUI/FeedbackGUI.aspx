<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FeedbackGUI.aspx.cs" Inherits="SE1436_Group2_Project.GUI.FeedbackGUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-fb">
    <div class="div-feed">
        <%if (Convert.ToInt32(Session["comment"]) == 1)
            { %>
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="44px" CssClass="star-l" ImageUrl="~/Images/like.png" Width="46px" OnClick="ImageButton1_Click" CausesValidation="False" />
            <asp:ImageButton ID="ImageButton2" runat="server" Height="44px" CssClass="star-r" ImageUrl="~/Images/dislike.png" OnClick="ImageButton2_Click" CausesValidation="False" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="500px" Height="99px" CssClass="fbcen form-control" placeholder="Nhập bình luận tại đây..." MaxLength="1" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  CssClass="mg-bt" ControlToValidate="TextBox1" ErrorMessage="Không được để bình luận trống"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="mg-bt btn btn-secondary" Text="Gửi" Height="39px" Width="54px" Enabled="False" OnClick="Button1_Click" />
            <br />
            </div>
        <%} %>
        <asp:Panel ID="Panel1" runat="server" CssClass="box-fb">
            <asp:Label ID="Label1" runat="server" Text="3 bình luận gần nhất" Font-Bold="True"></asp:Label>
            <br />
            <br />
        </asp:Panel>
        
    </div>
</div>
</asp:Content>
