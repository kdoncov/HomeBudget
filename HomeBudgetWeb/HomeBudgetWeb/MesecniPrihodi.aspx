<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MesecniPrihodi.aspx.cs" Inherits="HomeBudgetWeb.MesecniPrihodi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainPlaceholder" runat="server">
    <div>   
        <table class="nav-justified">
        <tr>
            <td>
                <asp:Label ID="lblGodina" runat="server" Text="Godina"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblMesec" runat="server" Text="Mesec"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblVrsteP" runat="server" Text="Vrste Prihoda"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Podvrsta Prihoda"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="dpdGodina" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="dpdList" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="dpdVrstePrihoda" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="dpdPodvrstePrihoda" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnFilter" runat="server" Text="Filter" />
            </td>
        </tr>
    </table>
    </div>
    <asp:GridView ID="gvMesecniPrihodi" runat="server" DataSourceID="ObjectDataSource1cfydfadfgasd"></asp:GridView>
    
    </asp:Content>
