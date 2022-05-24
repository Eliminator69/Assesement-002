    <form id="form1" runat="server">
        <p style="height: 33px; width: 1313px">
            Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtusername" runat="server" style="margin-bottom: 0px" Width="211px"></asp:TextBox>
        </p>
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox TextMode="Password" ID="txtpassword" runat="server" Width="213px" OnTextChanged="txtpassword_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="messagelbl" runat="server" Text="Label"></asp:Label>
        <p style="height: 158px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="279px" />
        </p>
        <p style="height: 158px">
            &nbsp;</p>
    </form>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPLoginSystem.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    </body>
</html>
