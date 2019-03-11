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
                        <asp:TextBox ID="txtUsername" required="true" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPassword" required="true"  runat ="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogIn" runat="server" Text="Login" OnClick="btnLogIn_Click" />
                    </td>
                    <td>
                        <asp:LinkButton ID="lnkBtnRegister" runat="server" OnClick="lnkBtnRegister_Click">Register</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
