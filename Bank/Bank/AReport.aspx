<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AReport.aspx.cs" Inherits="Bank.Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Result</h1>
        <Pigeon:HomeBtn runat="server" ID="HomeBtn"/>
        <Pigeon:CommonBtns runat="server" ID="CommonBtn"/>
        <br />
        <asp:GridView ID="GridViewResult" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
