<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControl.aspx.cs" Inherits="WebControls.WebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Controls Demonstration</title>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 402px;
        }
        .auto-style3 {
            width: 402px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <h3>
        Registration Form</h3>
        <p>
            Please fill in all fields and click the Registration button<br />
    </p>
        <h3>
            <asp:Image ID="userInformationImage" runat="server" Height="17px" ImageUrl="~/user.png" Width="203px" />
        </h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="firstNameImage" runat="server" Height="19px" ImageUrl="~/fname.png" Width="86px" />
&nbsp;<asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Image ID="lastNameImage" runat="server" Height="22px" ImageUrl="~/lname.png" style="margin-left: 0px" Width="75px" />
&nbsp;
                    <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Image ID="emailImage" runat="server" Height="25px" ImageUrl="~/email.png" Width="82px" />
&nbsp;
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Image ID="phoneImage" runat="server" ImageUrl="~/phone.png" Width="74px" />
&nbsp;
                    <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Image ID="publicationImage" runat="server" ImageUrl="~/publications.png" />
        <br />
        <br />
        Which book would you like information about?
        <br />
        <asp:DropDownList ID="booksDropDownList" runat="server">
            <asp:ListItem>Visual Basic 2012 How to Program</asp:ListItem>
            <asp:ListItem>Visual C# 2012 How to Program</asp:ListItem>
            <asp:ListItem>Java How to Program</asp:ListItem>
            <asp:ListItem>C++ How to Program</asp:ListItem>
        </asp:DropDownList>
&nbsp;<br />
        <asp:HyperLink ID="booksHyperLink" runat="server" NavigateUrl=" http://www.deitel.com" Target="_blank">Click here to view more about information of our books.</asp:HyperLink>
        <br />
        <br />
        <asp:Image ID="osImage" runat="server" ImageUrl="~/os.png" />
        <br />
        <asp:RadioButtonList ID="osRadioButtonList" runat="server">
            <asp:ListItem>Windows 7</asp:ListItem>
            <asp:ListItem>Windows 8</asp:ListItem>
            <asp:ListItem>MAC OS X</asp:ListItem>
            <asp:ListItem>Linux</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="registerButton" runat="server" Text="Register" Width="76px" />
    </form>
</body>
</html>
