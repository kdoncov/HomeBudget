<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MesecniPrihodi.aspx.cs" Inherits="HomeBudgetWeb.MesecniPrihodi" %>

<asp:Content ID="btn" ContentPlaceHolderID="MainPlaceholder" runat="server">
    <div>
        <table class="nav-justified">
            <tr>
                <td style="height: 20px">
                    <asp:Label ID="lblGodina" runat="server" Text="Godina"></asp:Label>
                </td>
                <td style="height: 20px">
                    <asp:Label ID="lblMesec" runat="server" Text="Mesec"></asp:Label>
                </td>
                <td style="height: 20px">
                    <asp:Label ID="lblVrsteP" runat="server" Text="Vrste Prihoda"></asp:Label>
                </td>
                <td style="height: 20px">
                    <asp:Label ID="Label1" runat="server" Text="Podvrsta Prihoda"></asp:Label>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="dpdGodina" runat="server" CssClass="select-style">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="dpdMesec" runat="server" CssClass="select-style">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:DropDownList ID="dpdVrstePrihoda" runat="server" CssClass="select-style">
                    </asp:DropDownList>
                </td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <td>
                            <asp:DropDownList ID="dpdPodvrstePrihoda" runat="server" CssClass="select-style">
                            </asp:DropDownList>
                        </td>
                    </ContentTemplate>

                </asp:UpdatePanel>

                <td>
                    <asp:Button ID="btnFilter" runat="server" Text="Filter" />
                </td>
            </tr>
        </table>
    </div>
    <asp:GridView ID="gvMesecniPrihodi" runat="server"></asp:GridView>
    <asp:LinkButton ID="lnkBtnAdd" href="#open-modal" runat="server" Text="Dodaj">Dodaj</asp:LinkButton>
    <asp:Button ID="btnUpdate" runat="server" Text="Izmeni" />
    <asp:Button ID="btnDelete" runat="server" Text="Obriši" />

    <div>
        <%--<a href="#open-modal">Open Modal</a>--%>
        <div id="open-modal" class="modal-window">
            <div>


                <table class="nav-justified">
                    <tr>
                        <td>
                            <asp:Label ID="lblDate" runat="server" Text="Datum:"></asp:Label></td>
                        <td>
                            <input runat="server" id="inpDate" name="checkDate" type="date" /><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTypeTransfer" runat="server" Text="Vrsta prihoda:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtTypeTransfer" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblTransferSubtype" runat="server" Text="Podvrsta prihoda:"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtTransferSubtype" runat="server"></asp:TextBox><br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblAmount" runat="server" Text="Iznos"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAdd" runat="server" Text="Dodaj" OnClick="btnAdd_Click" /></td>
                        <td>
                            <asp:Button ID="btnCancel" runat="server" Text="Odustani" /></td>
                    </tr>
                </table>


                <a href="#" title="Close" class="modal-close">close &times;</a>


            </div>
        </div>
    </div>
</asp:Content>
