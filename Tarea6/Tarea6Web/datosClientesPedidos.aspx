<%@ Page Language="C#" AutoEventWireup="true" CodeFile="datosClientesPedidos.aspx.cs" Inherits="datosClientesPedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 413px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #33CC33">
    <div style="height: 387px">
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 147px; top: 36px; position: absolute" Text="Información del Cliente:"></asp:Label>
        <asp:Table ID="tblInfoCliente" runat="server" BorderColor="Black" BorderStyle="Solid" style="z-index: 1; left: 152px; top: 79px; position: absolute; height: 25px; width: 453px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">RFC</asp:TableCell>
                <asp:TableCell runat="server">Nombre</asp:TableCell>
                <asp:TableCell runat="server">Dirección</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server" ID="tblCliente"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 154px; top: 160px; position: absolute; right: 845px" Text="Pedidos:"></asp:Label>
        <asp:Table ID="tblInfoPedidos" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" GridLines="Both" style="z-index: 1; left: 157px; top: 214px; position: absolute; height: 48px; width: 362px">
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
        <asp:DropDownList ID="ddlFPedidos" runat="server" style="z-index: 1; left: 342px; top: 159px; position: absolute">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
