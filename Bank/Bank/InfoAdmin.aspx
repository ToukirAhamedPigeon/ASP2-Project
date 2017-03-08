<%@ Page Title="" Language="C#" MasterPageFile="~/Info.Master" AutoEventWireup="true" CodeBehind="InfoAdmin.aspx.cs" Inherits="Bank.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="mid">Admin</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
  <asp:DropDownList ID="DropDownListAction" runat="server">
        <asp:ListItem>Select Action</asp:ListItem>
        <asp:ListItem>Search Customer</asp:ListItem>
        <asp:ListItem>Search Admin</asp:ListItem>
        <asp:ListItem>Search Employee</asp:ListItem>
        <asp:ListItem>Add New Customer</asp:ListItem>
        <asp:ListItem>Add New Employee</asp:ListItem>
        <asp:ListItem>Custom Bank Report</asp:ListItem>
        <asp:ListItem>Edit Info</asp:ListItem>
        <asp:ListItem>Give Salary</asp:ListItem>
    </asp:DropDownList>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table>
        <tr>
            <td>
                <asp:Label ID="Label21" runat="server" Text="Status: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelStatus" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label30" runat="server" Text="About: "></asp:Label>
            </td>
            <td>
                 <blockquote id="bqAbout">About</blockquote>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label22" runat="server" Text="Balance: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelBalance" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Usable: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelUsable" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:Label ID="Label25" runat="server" Text="Work History:"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:GridView ID="GridViewWorkHistory" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

