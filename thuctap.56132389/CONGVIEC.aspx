<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CONGVIEC.aspx.cs" Inherits="CONGVIEC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style4
    {
        height: 23px;
        text-align: center;
    }
    .auto-style5
    {
        width: 43px;
    }
        .auto-style6
        {
            height: 23px;
            text-align: center;
            width: 329px;
        }
        .auto-style7
        {
        }
        .auto-style8
        {
            width: 355px;
            color: #CC3399;
        }
        .auto-style9
        {
        width: 355px;
    }
    .auto-style10
    {
        width: 37px;
        color: #CC3399;
    }
    .auto-style11
    {
        margin-left: 0px;
    }
    .auto-style12
    {
        width: 355px;
        height: 137px;
    }
    .auto-style13
    {
        height: 137px;
    }
    .auto-style14
    {
        height: 23px;
        text-align: center;
        width: 355px;
    }
    .auto-style15
    {
        width: 77px;
    }
    .auto-style16
    {
        margin-left: 12px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style4" colspan="3">DANH SÁCH VIỆC CẦN LÀM THÁNG 6/2017</td>
        </tr>
        <tr>
            <td class="auto-style12">
                </td>
            <td colspan="3" class="auto-style13">
                <asp:GridView ID="GVCV" runat="server" CssClass="auto-style11">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style1">
                CẬP NHẬT CÔNG VIỆC</td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">
                MSSV</td>
            <td colspan="3">
                <asp:TextBox ID="txtmssv" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                MÃ CÔNG VIỆC</td>
            <td colspan="3">
                <asp:TextBox ID="txtmcv" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                NGÀY BẮT ĐẦU</td>
            <td colspan="3">
                <asp:TextBox ID="txtngaybd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                NGÀY KẾT THÚC</td>
            <td colspan="3">
                <asp:TextBox ID="txtngaykt" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                KẾT QUẢ</td>
            <td colspan="3">
                <asp:TextBox ID="txtkq" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style7">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">
                &nbsp;</td>
            <td class="auto-style10">
                <asp:Button ID="btnThem" runat="server" Text="THÊM" OnClick="btnThem_Click" style="margin-left: 0px" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btnsua" runat="server" Text="SỬA" CssClass="auto-style16" OnClick="btnsua_Click" />
            </td>
            <td>
                <asp:Button ID="btnXoa" runat="server" Text="XÓA" OnClick="btnXoa_Click" />
            </td>
        </tr>
    </table>
</p>
</asp:Content>

