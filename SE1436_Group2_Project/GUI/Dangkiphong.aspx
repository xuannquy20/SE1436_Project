<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dangkiphong.aspx.cs" Inherits="SE1436_Group2_Project.GUI.Dangkiphong" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .bg-dangki {
            background-color: antiquewhite;
            width: 100%;
            height: 700px;
        }

        .box-dangki {
            width: 550px;
            height: 550px;
            border: 2px solid red;
            border-radius: 10px;
        }

        .title {
            font-size: 40px;
            color: saddlebrown;
            padding-left: 100px;
        }
        
        .auto-style8 {
            width: 237%;
            height: 68px;
        }
        .auto-style9 {
            width: 425px;
        }
        .auto-style12 {
            margin-top: 0px;
        }
        .auto-style13 {
            width: 129px;
        }
        .auto-style14 {
            width: 129px;
            height: 72px;
        }
        .auto-style15 {
            height: 72px;
        }
        .auto-style16 {
            width: 100%;
            height: 206px;
        }
    .auto-style17 {
        height: 61px;
    }
        .auto-style18 {
            background-color: antiquewhite;
            width: 42%;
            height: 700px;
        }
        .auto-style20 {
            width: 438px;
        }
        .auto-style21 {
            width: 227px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style18">       
            <table class="auto-style8">
                <tr>
                    <td class="auto-style9">
                       
                               
                                    <asp:Label ID="Label1" runat="server" Text="Check In"></asp:Label>
                                    <asp:Calendar ID="checkIn" runat="server" CssClass="auto-style12" Height="256px"></asp:Calendar>
                             
                                
                         
                           
                             
                                    <asp:Label ID="Label2" runat="server" Text="Check Out"></asp:Label>
                                    <asp:Calendar ID="checkOut" runat="server"></asp:Calendar>
                          
                        
                      
                    </td>
                    <td class="auto-style21">
                        <div class="box-dangki">
                            <br />
                            <br />
                            <div class="title">
                                <asp:Label ID="LabelBook" runat="server" Text="BOOKING ROOMS"></asp:Label>
                            </div>
                            <br />
                            <br />                            
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <table class="auto-style16">
                                <tr> 
                                    <td class="auto-style17"></td>
                                    <td class="auto-style17">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="human" ErrorMessage="Hãy điền vào mục này!"></asp:RequiredFieldValidator>
                                        <asp:TextBox CssClass="form-control" ID="human" runat="server" Width="272px" placeholder="Số lượng người" Height="28px"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Text="Tầng:"></asp:Label></td>
                                    <td class="auto-style15"><asp:DropDownList CssClass="form-control" ID="floor" runat="server" Width="356px" AutoPostBack="True" OnSelectedIndexChanged="floor_SelectedIndexChanged" ></asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label4" runat="server" Text="Phòng:"></asp:Label></td>
                                    <td><asp:DropDownList CssClass="form-control" ID="room" runat="server" Width="354px" ></asp:DropDownList></td>
                                </tr>
                            </table>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server" Text="Chốt Đơn" Width="160px" OnClick="Button1_Click" />
                            <br />
                        </div>
                    </td>
                    <td class="auto-style20">
                        <asp:Image ID="Image1" runat="server" />                   
                    </td>
                </tr>
            </table>
    </div>
</asp:Content>
