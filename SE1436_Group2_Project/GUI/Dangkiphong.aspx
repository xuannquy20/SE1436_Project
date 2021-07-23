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
            background-color: burlywood;
            width: 42%;
            height: 700px;
        }
        .auto-style20 {
            width: 438px;
        }
        .auto-style21 {
            width: 227px;
        }
        .anh{
            display: flex;
            width:75%;
            height: auto;
            margin-bottom: 10px;
            margin: 0px auto;
        }
        .div-anh{
            height: 550px;
            border: 1px solid black;
            border-radius: 5px;
            padding: 0px 10px;
            background-color: white;
        }
        .auto-style22 {
            display: block;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-clip: padding-box;
            border-radius: .25rem;
            transition: none;
            border: 1px solid #ced4da;
            background-color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style18">       
            <table class="auto-style8">
                <tr>
                    <td class="auto-style9"> 
                        <div class="div-anh">
                        <asp:Image ID="Image1" runat="server" CssClass="anh img-thumbnail"/>
                        <br />
                        <div class="font-italic">Phòng Deluxe được thiết kế tinh tế sang trọng nội thất đầy đủ tiện nghi hiện đại, 
                            cửa sổ kính rộng thoáng bao quát toàn cảnh thành phố mang đến cho bạn một không gian thanh bình 
                            và dễ chịu sẽ là sự lựa chọn cho những doanh nhân và khách du lịch.
                        </div>
                        </div>
                    </td>
                    <% if (Session["user"] != null)
                        { %>
                    <td class="auto-style21">
                        <div class="box-dangki" style="background-color: white;">
                            <br />
                            <br />
                            <div class="title">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="LabelBook" runat="server" Text="ĐẶT PHÒNG"></asp:Label>
                            </div>
                            <br />
                            <br />
                            <br />
                            <table class="auto-style16">
                                <tr> 
                                    <td class="auto-style17"></td>
                                    <td class="auto-style17">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="human" ErrorMessage="Hãy điền vào mục này!"></asp:RequiredFieldValidator>
                                        <asp:TextBox CssClass="auto-style22 form-control" ID="human" runat="server" Width="356px" placeholder="Số lượng người" Height="37px"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td class="auto-style14">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label3" runat="server" Text="Tầng:"></asp:Label></td>
                                    <td class="auto-style15"><asp:DropDownList CssClass="form-control" ID="floor" runat="server" Width="356px" AutoPostBack="True" OnSelectedIndexChanged="floor_SelectedIndexChanged" ></asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label4" runat="server" Text="Phòng:"></asp:Label></td>
                                    <td><asp:DropDownList CssClass="form-control" ID="room" runat="server" Width="356px" ></asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="Chốt Đơn" Width="160px" CssClass="btn btn-success" OnClick="Button1_Click" /></td>
                                </tr>
                            </table>
                            <br />
                        </div>
                    </td>
                    <td class="auto-style20">
                                    <asp:Label ID="Label5" runat="server" Text="Từ ngày" CssClass="font-weight-bold"></asp:Label>
                                    <asp:Calendar ID="checkIn" runat="server" CssClass="table-hover" Height="256px" NextMonthText=""></asp:Calendar>
                                    <asp:Label ID="Label2" runat="server" Text="Đến ngày" CssClass="font-weight-bold"></asp:Label>
                                    <asp:Calendar ID="checkOut" runat="server" CssClass="table-hover"></asp:Calendar>
                    </td>
                    <%} %>
                </tr>
            </table>
    </div>
</asp:Content>
