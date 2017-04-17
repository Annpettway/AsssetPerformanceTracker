<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AsssetPerformanceTracker023.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style3 {
            width: 184px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>
        <img class="auto-style3" src="Models/epic-spies-logo.jpg" /><br />
        <asp:Image ID="Image1" runat="server" />
        <br />
        Asset Performance Tracker<br />
        <br />
        Asset Name:&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged:&nbsp;
        <asp:TextBox ID="riggedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of Subterfuge Performed:&nbsp;
        <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </strong>
    
    </div>
    </form>
</body>
</html>
