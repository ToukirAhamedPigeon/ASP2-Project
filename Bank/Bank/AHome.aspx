<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AHome.aspx.cs" Inherits="Bank.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="CSS/PigeonStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="mid">
    <h1>Bank Home</h1>
    <asp:Label ID="Label1" runat="server" Text="Log In As "></asp:Label>
    <asp:DropDownList ID="DropDownListUser" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListUser_SelectedIndexChanged">
        <asp:ListItem>Select</asp:ListItem>
        <asp:ListItem>Customer</asp:ListItem>
        <asp:ListItem>Employee</asp:ListItem>
        <asp:ListItem>Admin</asp:ListItem>
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
