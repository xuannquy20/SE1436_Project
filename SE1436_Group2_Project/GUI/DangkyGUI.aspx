<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangkyGUI.aspx.cs" Inherits="SE1436_Group2_Project.GUI.DangkyGUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:300,400,700"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto+Slab:300,400"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Sancreek"/>
</head>
<body>
    <style type="text/css">
        body { 
        background: url('../Images/login.jpg') no-repeat center center fixed; 
        -webkit-background-size: cover;
        -moz-background-size: cover;
        -o-background-size: cover;
        background-size: cover;
        }
        .keep{
            width: 500px;
            height:500px;
            margin:auto;
        }
        .mid{
            margin: auto 100px;
            background-color: white;
        }
        .cen{
            margin: 130px 0px;
            padding-top:50px;
            padding-bottom: 50px;
            background-color: white;
            border: 1px solid white;
            border-radius: 10px;
        }

        .bt-l{
            margin-left: 100px;
            opacity: 100%;
        }

        .bt-r{
            float: right;
            margin-right: 100px;
            opacity: 100%;
        }

        .check{
            margin-left: 100px;
        }
        .logo{
            margin-left: 150px;
            margin-right: 150px;
        }
    </style>

    <form id="form1" runat="server" class="keep">
        <div class="cen">
            <asp:Image ID="Image1" runat="server" Height="113px" ImageUrl="~/Images/logo.png" CssClass="logo"/>
            <asp:Label ID="Label1" runat="server" Text="Tài khoản đã trùng" CssClass="check" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsername" runat="server" Width="300px" placeholder="Tên tài khoản" CssClass="mid form-control" Height="51px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Không được bỏ trống tên tài khoản" CssClass="check"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" Width="300px" CssClass="mid form-control" Height="51px" placeholder="Mật khẩu" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Không được bỏ trống mật khẩu" CssClass="check"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtPassword0" runat="server" Width="300px" CssClass="mid form-control" Height="51px" placeholder="Nhập lại mật khẩu" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword0" ErrorMessage="Không được bỏ trống mật khẩu" CssClass="check"></asp:RequiredFieldValidator>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPassword0" ErrorMessage="Mật khẩu nhập lại không trùng" CssClass="check"></asp:CompareValidator>
            <asp:Button ID="Button1" runat="server" Text="Đăng ký" Width="130px" CssClass="bt-l btn btn-success" OnClick="Button1_Click"/>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
