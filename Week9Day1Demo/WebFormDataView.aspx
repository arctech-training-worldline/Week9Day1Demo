<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormDataView.aspx.cs" Inherits="Week9Day1Demo.WebFormDataView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"
                BackColor="WhiteSmoke" BorderColor="YellowGreen" BorderStyle="None"
                BorderWidth="1px" CellPadding="4">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
