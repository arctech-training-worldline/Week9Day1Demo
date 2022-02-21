<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormGenericDemo.aspx.cs" Inherits="Week9Day1Demo.WebFormGenericDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Strings</h2>
            <asp:TextBox runat="server" ID="TextBoxLeftSide" />
            <asp:TextBox runat="server" ID="TextBoxRightSide" />
            <asp:Button runat="server" ID="ButtonSwap" OnClick="ButtonSwap_OnClick" Text="Swap" />
            <asp:Button runat="server" ID="ButtonSwapGeneric" OnClick="ButtonSwapGeneric_OnClick" Text="Swap Generic" />
            
            <h2>Integers</h2>
            <asp:TextBox runat="server" ID="TextBoxNumberLeftSide" TextMode="Number" />
            <asp:TextBox runat="server" ID="TextBoxNumberRightSide" TextMode="Number" />
            <asp:Button runat="server" ID="ButtonSwapNumbers" OnClick="ButtonSwapNumbers_Click" Text="Swap Number" />
            <asp:Button runat="server" ID="ButtonSwapNumbersGeneric" OnClick="ButtonSwapNumbersGeneric_Click" Text="Swap Number Generic" />
        </div>
    </form>
</body>
</html>
