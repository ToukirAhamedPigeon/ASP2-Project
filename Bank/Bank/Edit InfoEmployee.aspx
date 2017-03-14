<%@ Page Title="" Language="C#" MasterPageFile="~/Edit Info.Master" AutoEventWireup="true" CodeBehind="Edit InfoEmployee.aspx.cs" Inherits="Bank.WebForm19" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table>
            <tr>
                <td>
                    <h1>Employee</h1>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Post: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxPost" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label23" runat="server" Text="Salary: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonEditEmp" runat="server" Text="Edit" />
                </td>
                <td>
                    <asp:Button ID="ButtonCancelEmp" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
</asp:Content>