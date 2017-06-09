<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DIEMTHI.aspx.cs" Inherits="DIEMTHI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style1">
    BẢNG ĐIỂM CHI TIẾT CỦA SINH VIÊN</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
</asp:Content>

