<%@ Page Title="" Language="C#" MasterPageFile="~/Edit Info.Master" AutoEventWireup="true" CodeBehind="Edit InfoCustomer.aspx.cs" Inherits="Bank.WebForm18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <table>
            <tr>
                <td>
              <h1>Nominy</h1>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Nominy Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNomName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Nominy DOB: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNomDOB" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Nominy Age: "></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNomAge" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="Nominy SGender: "></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonListNomGender" runat="server">
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="Nominy NID Type: "></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonListNomNIDType" runat="server">
                        <asp:ListItem>NID</asp:ListItem>
                        <asp:ListItem>Passport</asp:ListItem>
                        <asp:ListItem>Birth ID</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="Nominy National ID NO: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNomNIDNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label19" runat="server" Text=" Nominy Phone: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNomPhone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label20" runat="server" Text="Nominy Address: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNomAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="Nominy Email: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxNomEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="Change Nominy Profile Picture: "></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUploadNomProPic" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonEdit" runat="server" Text="Edit" OnClick="ButtonEdit_Click" />
                </td>
                <td>
                     <asp:Button ID="ButtonNom" runat="server" Text="Owner Change" OnClick="ButtonNom_Click" />
                </td>
                <td> 
                   <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                </td>
            </tr>
        </table>
</asp:Content>