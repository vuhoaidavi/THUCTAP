<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DANGNHAP.aspx.cs" Inherits="DANGNHAP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style4
    {
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style4">Đăng nhập tài khoản</td>
            <td>
                <asp:TextBox ID="txtMSSV" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">
                <asp:Button ID="btndangnhap" runat="server" Text="ĐĂNG NHẬP" OnClick="btndangnhap_Click" />
            </td>
        </tr>
    </table>
</p>
</asp:Content>

