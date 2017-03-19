<%@ Page Title="" Language="C#" MasterPageFile="~/Change Password.Master" AutoEventWireup="true" CodeBehind="ChangePasswordAdmin.aspx.cs" Inherits="Bank.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table>
            <tr>
                <td>
                    <asp:Button ID="ButtonConfirm" runat="server" Text="Confirm" OnClick="ButtonConfirm_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                </td>
            </tr>
        </table>
</asp:Content>
