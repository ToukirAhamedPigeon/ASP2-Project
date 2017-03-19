<%@ Page Title="" Language="C#" MasterPageFile="~/DepositWithdraw.Master" AutoEventWireup="true" CodeBehind="DepositWithdrawO.aspx.cs" Inherits="Bank.WebForm27" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="To A/C: "></asp:Label>
                </td>
                <td>
                <asp:TextBox ID="TextBoxOther" runat="server"></asp:TextBox>
                </td>
            </tr>
            </table>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table>
            <tr>
                <td>
                    <asp:Button ID="ButtonConfirm" runat="server" Text="Confirm" OnClick="ButtonConfirm_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
</asp:Content>
