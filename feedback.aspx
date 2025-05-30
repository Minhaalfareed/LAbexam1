<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="helpFeedback.aspx.cs" Inherits="LAbexam1.helpFeedback" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback Records</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
            padding: 20px;
        }

        h2 {
            color: #333;
        }

        .grid {
            background-color: white;
            border: 1px solid #ccc;
            padding: 10px;
            width: 100%;
        }

        .grid th {
            background-color: #4CAF50;
            color: white;
            padding: 10px;
        }

        .grid td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>All Feedback Records</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" CssClass="grid"></asp:GridView>
    </form>
</body>
</html>
