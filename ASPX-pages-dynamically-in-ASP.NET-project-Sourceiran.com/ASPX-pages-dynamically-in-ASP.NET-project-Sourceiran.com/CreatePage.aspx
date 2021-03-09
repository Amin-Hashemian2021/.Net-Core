<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreatePage.aspx.cs" Inherits="CreatePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td style="width: 100px">
                    Title</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Meta Description</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtDes" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Meta Keywords</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtKey" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Content</td>
                <td style="width: 100px">
                    <asp:TextBox ID="txtContent" runat="server" Height="292px" TextMode="MultiLine" Width="510px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 100px">
                </td>
                <td style="width: 100px">
                    <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
