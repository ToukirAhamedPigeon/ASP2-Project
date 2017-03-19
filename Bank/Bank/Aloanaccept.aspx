<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aloanaccept.aspx.cs" Inherits="Bank.Aloanaccept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Loan Result</h1>
      
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="LoanId">
            <Columns>
                <asp:BoundField HeaderText="Loan ID" ReadOnly="True" AccessibleHeaderText="LoanId" />
                <asp:TemplateField HeaderText="Request A/C">
                    <EditItemTemplate>
                        <asp:Label ID="LabelRequestAC" runat="server" Text='<%# Bind("LoanRequestAC") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLinkRequestAC" runat="server"  Text='<%# Bind("LoanRequestAC") %>' NavigateUrl='<%# Bind("~InfoSearcCustomer.aspx?CustomerAC="+LabelRequestAC.Text) %>' ></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField AccessibleHeaderText="Response" HeaderText="Response" ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" CausesValidation="false" CommandName="" OnClick="Button1_Click" Text="Response"></asp:Button>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
