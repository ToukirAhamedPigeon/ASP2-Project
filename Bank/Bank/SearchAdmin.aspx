<%@ Page Title="" Language="C#" MasterPageFile="~/Search.Master" AutoEventWireup="true" CodeBehind="SearchAdmin.aspx.cs" Inherits="Bank.WebForm24" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <table> 
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Search Employee"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxSearchEmployee" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                   <asp:GridView ID="GridViewEmployee" runat="server"></asp:GridView>
               </td>
            </tr>   
        </table>
     
</asp:Content>