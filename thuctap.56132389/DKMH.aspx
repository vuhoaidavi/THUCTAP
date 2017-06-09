<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DKMH.aspx.cs" Inherits="DKMH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style7
    {
        width: 84px;
    }
    .auto-style8
    {
        }
        .auto-style9
        {
            text-align: center;
            width: 118px;
        }
        .auto-style10
        {
        width: 118px;
    }
    .auto-style11
    {
        width: 78px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td class="auto-style9">
            &nbsp;</td>
        <td class="auto-style1" colspan="3">
            ĐĂNG KÝ MÔN HỌC&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style8" colspan="3">
            <asp:GridView ID="GVDKMH" runat="server" style="text-align: center">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style10"></td>
        <td class="auto-style8" colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style8" colspan="3">CẬP NHẬT MÔN HỌC</td>
    </tr>
    <tr>
        <td class="auto-style10">MÃ MÔN HỌC</td>
        <td class="auto-style8" colspan="3">
            <asp:TextBox ID="txtmamh" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">TÊN MÔN HỌC</td>
        <td class="auto-style8" colspan="3">
            <asp:TextBox ID="txttenmh" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">MÃ SỐ SV</td>
        <td class="auto-style8" colspan="3">
            <asp:TextBox ID="txtmssv" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">HỌC KỲ</td>
        <td class="auto-style8" colspan="3">
            <asp:TextBox ID="txthocky" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style8" colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10">
            &nbsp;</td>
        <td class="auto-style11">
            <asp:Button ID="btnThem" runat="server" Text="THÊM" OnClick="btnThem_Click" />
        </td>
        <td class="auto-style7">
            <asp:Button ID="btnSua" runat="server" Text="SỬA" OnClick="btnSua_Click" />
        </td>
        <td>
            <asp:Button ID="btnXoa" runat="server" Text="XÓA" OnClick="btnXoa_Click" />
        </td>
    </tr>
</table>
</asp:Content>

