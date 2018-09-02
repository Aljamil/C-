<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="Validation.Validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demonstrating Validation Controls</title>
    <style type="text/css">

.fontstyle0
{
	font-family:LucidaSansTypewriter-OV-DFCUGA;
	font-size:8pt;
	font-style:normal;
	font-weight:normal;
	color:rgb(0,0,0);
}
        .auto-style1 {
            font-family: LucidaSansTypewriter-OV-DFCUGA;
            font-size: medium;
            font-style: normal;
            font-weight: normal;
            color: rgb(0,0,0);
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3><span class="auto-style1"><strong>Please fill in all the fields in the following form:</strong></span> </h3>
            <h3>
                <table class="auto-style2">
                    <tr>
                        <td>Name:</td>
                        <td>
                            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="nameRequiredFieldValidator" runat="server" ControlToValidate="nameTextBox" Display="Dynamic" ErrorMessage="Please Enter your Name." ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Email:</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="emailTextBox" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;<a href="mailto:email@domain">email@domain</a><br />
                            <asp:RequiredFieldValidator ID="emailRequiredFieldValidator1" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Please enter your e-mail" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="phoneRegularExpressionValidator" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="&quot;Please enter an e-mail address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Phone:</td>
                        <td>
                            <asp:TextBox ID="phoneTextBox" runat="server" TextMode="Phone"></asp:TextBox>
&nbsp;(555) 555-1234<br />
                            <asp:RequiredFieldValidator ID="phoneRequiredFieldValidator" runat="server" ControlToValidate="phoneTextBox" Display="Dynamic" ErrorMessage="Please enter your Phone Number" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="cpRegularExpressionValidator" runat="server" ControlToValidate="phoneTextBox" Display="Dynamic" ErrorMessage="&quot;Please enter a phone number in a valid format&quot;" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
                <br style=" font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0px; " />
                <asp:Button ID="submitButton" runat="server" Text="Submit" />
            </h3>
            <p>
                <asp:Label ID="outputLabel" runat="server" Visible="False"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
