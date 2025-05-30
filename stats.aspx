<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stats.aspx.cs" Inherits="LAbexam1.Stats" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback Stats</title>
    <style>
        body { font-family: Arial; background-color: #e0f7fa; padding: 30px; }
        h2 { color: #00796b; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Feedback Statistics</h2>
        <asp:Label ID="lblTotalSubmissions" runat="server" Font-Size="Large" /><br /><br />
        <asp:Label ID="lblLastEmail" runat="server" Font-Size="Medium" /><br /><br />
        <a href="helpFeedback.aspx">View All Feedback Records</a>
    </form>
</body>
</html>
