<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LAbexam1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                            Student Name:
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        CourseName:
                    </td>
                    <td>
                        <asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox>

                    </td>
                    
                </tr>
                <tr>
                    <td>Phone Number:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td>
                        comments:
                    </td>
                    <td>
                        <asp:TextBox ID="txtComments" runat="server" TextMode="MultiLine" Rows="4" Columns="20"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Insert" />
                        <asp:Button ID="Button2" runat="server" Text="submit" />
                        <asp:Button ID="Button3" runat="server" Text="Delete" />
                        <asp:Button ID="Button4" runat="server" Text="update" />
                    </td>
                    </tr>
            </table>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="grid">
    <Columns>
        <asp:BoundField DataField="StudentName" HeaderText="Student Name" />
        <asp:BoundField DataField="CourseName" HeaderText="Course Name" />
        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
        <asp:BoundField DataField="Comments" HeaderText="Comments" />
    </Columns>
</asp:GridView>

      </form>      
</body>
</html>
