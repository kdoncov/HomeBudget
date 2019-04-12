<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HomeBudgetWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <link rel="stylesheet" href="Content/testStyle.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-wrap">
	<div class="login-html">		
        <input id="tab1" runat="server" type="radio" name="tab" class="sign-in" checked /><label for="tab1" class="tab">Prijavi se</label>
		<input id="tab2" runat="server" type="radio" name="tab" class="sign-up" /><label for="tab2" class="tab">Registruj se</label>
		<div class="login-form">
			<div class="sign-in-htm">
				<div class="group">
					<label for="txtUsername" class="label">Korisničko ime</label>
					<asp:TextBox ID="txtUsername" runat="server" class="input"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtUsername" Text="*" ValidationGroup="vldLogin" ID="rvfUsername" class="validationMessage"></asp:RequiredFieldValidator>
				
                </div>
				<div class="group">
					<label for="txtPassword" class="label">Lozinka</label>
					<asp:TextBox ID="txtPassword" runat ="server" class="input" type="password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtPassword" Text="*" ValidationGroup="vldLogin" class="validationMessage"></asp:RequiredFieldValidator>
				</div>
				
				<div class="group">
					<asp:Button ID="btnLogIn" runat="server" Text="Prijava" class="button" OnClick="btnLogIn_Click" ValidationGroup="vldLogin"/>
                    <br />
                    <asp:Label ID="lblErrorLogin" runat="server" ViewStateMode="Disabled" EnableViewState="False"></asp:Label>
                </div>
				
			</div>
			<div class="sign-up-htm">
				<div class="group">
					<label for="txtName" class="label">Ime</label>
					<asp:TextBox ID="txtName"  runat="server" class="input"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtName" ValidationGroup="vldRegister" Text="*" class="validationMessage"></asp:RequiredFieldValidator>
				</div>
				<div class="group">
					<label for="txtSurname" class="label">Prezime</label>
					<asp:TextBox ID="txtSurname"  runat="server" class="input"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSurname" runat="server" ErrorMessage="RequiredFieldValidator" ValidationGroup="vldRegister" ControlToValidate="txtSurname" Text="*" class="validationMessage"></asp:RequiredFieldValidator>
				</div>
				<div class="group">
					<label for="txtUsernameRegister"" class="label">Korisničko ime</label>
					<asp:TextBox ID="txtUsernameRegister"  runat="server" class="input"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsernameRegister" runat="server" ErrorMessage="RequiredFieldValidator" ValidationGroup="vldRegister" ControlToValidate="txtUsernameRegister" Text="*" class="validationMessage"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblUsername" runat="server" ViewStateMode="Disabled" class="validationMessage"></asp:Label>
				</div>
				<div class="group">
					<label for="txtPasswordRegister" class="label">Lozinka</label>
					<asp:TextBox ID="txtPasswordRegister"  runat="server" class="input" type="password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPasswordRegister" runat="server" ErrorMessage="RequiredFieldValidator" ValidationGroup="vldRegister" ControlToValidate="txtPasswordRegister" class="validationMessage">*</asp:RequiredFieldValidator>
				</div>
				<div class="group">
					<asp:Button ID="btnRegister" runat="server" Text="Registracija" class="button" OnClick="btnRegister_Click" ValidationGroup="vldRegister" />
                    <asp:Label ID="lblInfo" runat="server"></asp:Label>
                </div>
				<div class="hr"></div>
                <br />
                <div class="foot-lnk">
					<label for="tab1" id="lblAlreadyMember" runat="server">Postojeći korisnik?</label>
				</div>

			</div>
		</div>
	</div>
</div>
    </form>
</body>
</html>
