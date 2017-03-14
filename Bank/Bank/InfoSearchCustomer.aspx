<%@ Page Title="" Language="C#" MasterPageFile="~/Info.Master" AutoEventWireup="true" CodeBehind="InfoSearchCustomer.aspx.cs" Inherits="Bank.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="mid">Search</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
   <asp:DropDownList ID="DropDownListAction" runat="server">
        <asp:ListItem>Select Action</asp:ListItem>
        <asp:ListItem>Money Transfer</asp:ListItem>
       <asp:ListItem>Money Deposit</asp:ListItem>
       <asp:ListItem>Money Withdraw</asp:ListItem>
       <asp:ListItem>Loan Request</asp:ListItem>
       <asp:ListItem>Edit Account</asp:ListItem>
       <asp:ListItem>Delete Account</asp:ListItem>
    </asp:DropDownList>
    <asp:Image ID="ImageProfile" CssClass="mid" runat="server" Height="150px" Width="150px" ImageAlign="Middle" ImageUrl="~/Images/profile-placeholder.png" /><br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <table>
        <tr>
            <td>
                <asp:Label ID="Label21" runat="server" Text="Type: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelAccountType" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label22" runat="server" Text="Balance: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelBalance" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
          <tr>
            <td>
                <asp:Label ID="Label27" runat="server" Text="Usable: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelUsable" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="Label23" runat="server" Text="Loan: "></asp:Label>
            </td>
            <td>
                 <asp:Label ID="LabelLoan" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                 <asp:Label ID="Label25" runat="server" Text="Work History: "></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <asp:GridView ID="GridViewWorkHistory" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
    <h3>Nominy</h3>
      <asp:Image ID="ImageNomProPic" runat="server" Height="150px" Width="150px" ImageUrl="~/Images/profile-placeholder.png" />
          <table>
             <tr>
                <td>
                     <asp:Label ID="Label3" runat="server" Text="Nominy Name: "></asp:Label>
                </td>
                 <td>
                      <asp:Label ID="LabelNomName" runat="server"></asp:Label><br />
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Label ID="Label5" runat="server" Text="Nominy Date Of Birth: "></asp:Label>
                </td>
                 <td>
                       <asp:Label ID="LabelNomDob" runat="server" Text="Label"></asp:Label><br />
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Label ID="Label7" runat="server" Text="Nominy Address: "></asp:Label>
                </td>
                 <td>
                       <asp:Label ID="LabelNomAddress" runat="server" Text="Label"></asp:Label><br />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nominy National ID: "></asp:Label>
                </td>
                 <td>
                      <asp:Label ID="LabelNomNID" runat="server" Text="Label"></asp:Label>
                </td>
                  <td>
                       <asp:Label ID="LabelNomNIDType" runat="server" Text="Label" BackColor="#0066FF" ForeColor="White"></asp:Label><br />
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Label ID="Label9" runat="server" Text="Nominy Phone: "></asp:Label>
                </td>
                 <td>
                      <asp:Label ID="LabelNomPhone" runat="server" Text="Label"></asp:Label><br />
                </td>
            </tr>
             <tr>
                <td>
                      <asp:Label ID="Label11" runat="server" Text="Nominy Email: "></asp:Label>
                </td>
                 <td>
                      <asp:Label ID="LabelNomEmail" runat="server" Text="Label"></asp:Label><br />
                </td>
            </tr>
             <tr>
                <td>
                     <asp:Label ID="Label13" runat="server" Text="Nominy Join: "></asp:Label>
                </td>
                 <td>
                      <asp:Label ID="LabelNomJoin" runat="server" Text="Label"></asp:Label><br />
                </td>
            </tr>
        </table>
</asp:Content>
