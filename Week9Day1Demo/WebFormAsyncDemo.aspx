<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAsyncDemo.aspx.cs" Inherits="Week9Day1Demo.WebFormAsyncDemo" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" id="ButtonTest" OnClick="ButtonTest_OnClick" Text="Test"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" id="ButtonTestAsync" OnClick="ButtonTestAsync_Click" Text="Test Async"/>
            <br />
            <br />
            <br />
            <asp:TextBox runat="server" Width="500" Height="500" TextMode="MultiLine" id="TextBoxMessage" />
        </div>
    </form>
</body>
</html>
