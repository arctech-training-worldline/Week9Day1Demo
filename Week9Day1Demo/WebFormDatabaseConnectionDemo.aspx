<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDatabaseConnectionDemo.aspx.cs" Inherits="Week9Day1Demo.WebFormDatabaseConnectionDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="ButtonShowAllOrders" Text="Show all Orders" OnClick="ButtonShowAllOrders_OnClick" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" ID="ButtonShowOrdersDataSet" Text="Show OrdersDataSet" OnClick="ButtonShowOrdersDataSet_Click" />
            <hr style="padding: 25px;"/>

            <asp:TextBox runat="server" ID="TextBoxRecords" TextMode="MultiLine" Width="500" Height="500"></asp:TextBox>

        </div>
    </form>
</body>
</html>
