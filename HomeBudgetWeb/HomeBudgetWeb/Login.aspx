<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeBudgetWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style1" colspan="2">Customer Login</td>
                </tr>
                <tr>
                    <td class="auto-style1">User name:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ButtonLogIn" runat="server" Text="Login" OnClick="ButtonLogIn_Click" />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButtonRegister" runat="server">Register</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
