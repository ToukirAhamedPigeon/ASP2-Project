<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ATransfer.aspx.cs" Inherits="Bank.Transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>
        Transfer
    </h1>
        <Pigeon:HomeBtn runat="server" ID="HomeBtn"/>
        <Pigeon:CommonBtns runat="server" ID="CommonBtn"/>
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="From: "></asp:Label> 
                </td>
                 <td>
                    <asp:Label ID="LabelFromAC" runat="server" Text="#"></asp:Label> 
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="To: "></asp:Label> 
                </td>
                 <td>
                     <asp:TextBox ID="TextBoxAccountNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Amount: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonConf" runat="server" Text="Confirm" />
                </td>
                <td>
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
