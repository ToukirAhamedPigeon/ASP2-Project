<%@ Page Title="" Language="C#" MasterPageFile="~/Info.Master" AutoEventWireup="true" CodeBehind="EmployeeInfo.aspx.cs" Inherits="Bank.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="mid">Employee</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:DropDownList ID="DropDownListAction" runat="server">
        <asp:ListItem>Select Action</asp:ListItem>
        <asp:ListItem>Search Customer</asp:ListItem>
        <asp:ListItem>Search Admin</asp:ListItem>
        <asp:ListItem>Add New Customer</asp:ListItem>
    </asp:DropDownList>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="Label21" runat="server" Text="Post: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelPost" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label22" runat="server" Text="Salary: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelSalary" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Time: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelTime" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:Label ID="Label25" runat="server" Text="Work History: "></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:GridView ID="GridViewWorkHistory" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

