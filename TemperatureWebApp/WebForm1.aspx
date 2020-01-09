<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TemperatureWebApp.WebForm1" %>

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
                    <td><asp:TextBox ID="input" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="CtoF" runat="server" Text="CtoF" OnClick="CtoF_Click" /></td>
                </tr>
                 <tr>
                    <td><asp:Button ID="FtoC" runat="server" Text="FtoC" OnClick="FtoC_Click" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="result" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
