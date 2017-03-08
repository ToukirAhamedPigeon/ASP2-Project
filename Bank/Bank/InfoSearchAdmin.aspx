<%@ Page Title="" Language="C#" MasterPageFile="~/Info.Master" AutoEventWireup="true" CodeBehind="InfoSearchAdmin.aspx.cs" Inherits="Bank.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
     <asp:DropDownList ID="DropDownListAction" runat="server">
         <asp:ListItem>Select Action</asp:ListItem>
       <asp:ListItem>Message</asp:ListItem>
    </asp:DropDownList>
    <asp:Image ID="ImageProfile" CssClass="mid" runat="server" Height="150px" Width="150px" ImageAlign="Middle" ImageUrl="~/Images/profile-placeholder.png" /><br />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
      </table>
</asp:Content>
