<%@ Page Title="" Language="C#" MasterPageFile="~/Registration.Master" AutoEventWireup="true" CodeBehind="RegistrationAdmin.aspx.cs" Inherits="Bank.WebForm23" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table>
    <tr>
                <td>
                    <asp:Button ID="ButtonEditEmp" runat="server" Text="Add" OnClick="ButtonEditEmp_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonCancelEmp" runat="server" Text="Cancel" OnClick="ButtonCancelEmp_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
