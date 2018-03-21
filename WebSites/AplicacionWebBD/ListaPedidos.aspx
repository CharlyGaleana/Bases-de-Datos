<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListaPedidos.aspx.cs" Inherits="ListaPedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pedidos de un Cliente</title>
    <style type="text/css">
        #form1 {
            height: 409px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #99FFCC">
    <div style="background-color: #FFFFFF; background-image: url('App_Images/j0216818.wmf'); height: 378px;">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Pagina Inicial</asp:HyperLink>
        <asp:Table ID="tblCliente" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" GridLines="Both" style="z-index: 1; left: 359px; top: 75px; position: absolute; height: 48px; width: 320px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">RFC</asp:TableCell>
                <asp:TableCell runat="server">Nombre</asp:TableCell>
                <asp:TableCell runat="server">Domicilio</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 361px; top: 37px; position: absolute" Text="Información de los pedidos de un cliente:"></asp:Label>
        <asp:DropDownList ID="ddlPedidos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPedidos_SelectedIndexChanged" style="z-index: 1; left: 518px; top: 144px; position: absolute; height: 22px; bottom: 84px">
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 397px; top: 146px; position: absolute" Text="Pedidos"></asp:Label>
        <asp:Table ID="tblPedidos" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" GridLines="Both" style="z-index: 1; left: 336px; top: 186px; position: absolute; height: 48px; width: 362px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Folio</asp:TableCell>
                <asp:TableCell runat="server">Fecha</asp:TableCell>
                <asp:TableCell runat="server">Total a Pagar</asp:TableCell>
                <asp:TableCell runat="server">Saldo Cliente</asp:TableCell>
                <asp:TableCell runat="server">Saldo de Facturas</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
