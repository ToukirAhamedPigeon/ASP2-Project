<%@ Page Title="" Language="C#" MasterPageFile="~/DepositWithdraw.Master" AutoEventWireup="true" CodeBehind="DepositWithdrawW.aspx.cs" Inherits="Bank.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table>
            <tr>
                <td>
                    <asp:Button ID="ButtonConfirm" runat="server" Text="Confirm" />
                </td>
                <td>
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
</asp:Content>