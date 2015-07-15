<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="Presentation.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div>                       
        </div>
        <table>
            <tr>
                <td colspan="3"><asp:Label ID="Label1" runat="server" Text="Ingresar al Sistema" Font-Bold="True" Font-Names="Tahoma" Font-Size="XX-Large"></asp:Label></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblUser" runat="server" Text="Usuario: " Font-Bold="True" Font-Names="Tahoma" Font-Size="1em"></asp:Label></td>
                <td><asp:TextBox ID="txtUser" runat="server" Width="186px"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPassword" runat="server" Text="Contraseña: " Font-Bold="True" Font-Names="Tahoma" Font-Size="1em"></asp:Label></td>
                <td><asp:TextBox ID="txtPassword" runat="server" Width="186px" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnEnter" runat="server" Text="Entrar" OnClick="btnEnter_Click" Width="81px" Font-Bold="True" Font-Names="Tahoma" Font-Size="1em"/></td>
                <td><asp:Label ID="lblResult" runat="server" ForeColor="Blue"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
