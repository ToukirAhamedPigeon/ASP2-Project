<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AloanReq.aspx.cs" Inherits="Bank.AloanReq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Loan Request</h1>
        <Pigeon:HomeBtn runat="server" ID="HomeBtn"/>
        <Pigeon:CommonBtns runat="server" ID="CommonBtn"/>
        <br />
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ID="Label1" runat="server" Text="Loan Amount: "></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="TextBoxAmount" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="ButtonReq" runat="server" Text="Request" />
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
