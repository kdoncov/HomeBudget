<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeBudgetWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style1" colspan="2">Customer Registration</td>
                </tr>
                <tr>
                    <td class="auto-style1">User name:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxUsernameReg" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="TextBoxPasswordReg" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="ButtonRegisterUser" runat="server" Text="Register" />
                    </td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButtonLogin" runat="server">Login</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
