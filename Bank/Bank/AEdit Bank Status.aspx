<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AEdit Bank Status.aspx.cs" Inherits="Bank.Edit_Bank_Status" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Edit Bank Status</h1>
        <Pigeon:HomeBtn runat="server" ID="HomeBtn"/>
        <Pigeon:CommonBtns runat="server" ID="CommonBtn"/>
        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Loan Status: "></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBoxLoanStatus" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Notice: "></asp:Label>
                </td>
            </tr>
            <tr>
               <td>
                    <asp:TextBox ID="TextBoxNotice" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                 <td>
                    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
