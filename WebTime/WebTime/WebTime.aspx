<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebTime.aspx.cs" Inherits="WebTime.WebTime" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Web Form Example</title>
    <style type="text/css">
        .timeStyle1 {
            color: #FFFF00;
            font-size: xx-large;
            background-color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Current Time on the Web Server: </h1>
        <p>
            <asp:Label ID="timeLabel" runat="server" CssClass="timeStyle1"></asp:Label>
        </p>
    </form>
</body>
</html>
