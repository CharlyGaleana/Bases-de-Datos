<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaPedido.aspx.cs" Inherits="AltaPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 254px">
    <form id="form1" runat="server" style="background-color: #33CCFF; height: 908px;">
    <div style="font-size: 20px">
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 504px; top: 17px; position: absolute; height: 67px; width: 132px" Text="Alta de Pedidos"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Agregar Artículos" style="z-index: 1; left: 82px; top: 35px; position: absolute"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 381px; top: 70px; position: absolute; right: 813px" Text="Clientes: " Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Artículo:  " style="z-index: 1; left: 12px; top: 73px; position: absolute"></asp:Label>
        <asp:DropDownList ID="Articulos" runat="server" style="z-index: 1; left: 92px; top: 72px; position: absolute">
        </asp:DropDownList>
            <asp:TextBox ID="Cantidad" runat="server" style="z-index: 1; left: 90px; top: 112px; position: absolute; width: 83px; right: 1064px;"></asp:TextBox>
        <asp:Button ID="Articulo" runat="server" Text="Agregar Articulo" OnClick="Articulo_Click" style="z-index: 1; left: 10px; top: 151px; position: absolute" />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 14px; top: 117px; position: absolute" Text="Cantidad"></asp:Label>
        <asp:GridView ID="GridViewArticulos" runat="server" style="z-index: 1; left: 15px; top: 226px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:Table ID="tblDetalles" runat="server" style="z-index: 1; left: 19px; top: 498px; position: absolute; height: 25px; width: 306px" Visible="False">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">FolioP</asp:TableCell>
                <asp:TableCell runat="server">FechaPed</asp:TableCell>
                <asp:TableCell runat="server">FechaFin</asp:TableCell>
                <asp:TableCell runat="server">Monto</asp:TableCell>
                <asp:TableCell runat="server">SaldoCli</asp:TableCell>
                <asp:TableCell runat="server">SaldoFacs</asp:TableCell>
                <asp:TableCell runat="server">RFCC</asp:TableCell>
                <asp:TableCell runat="server">RFCE</asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
                <asp:TableCell runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Button ID="Generar" runat="server" OnClick="Generar_Click" style="z-index: 1; left: 11px; top: 184px; position: absolute; width: 139px" Text="Generar Pedido" />
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 389px; top: 332px; position: absolute" Text="Total: "></asp:Label>
        <asp:Label ID="Total" runat="server" style="z-index: 1; left: 438px; top: 332px; position: absolute"></asp:Label>
        <asp:DropDownList ID="Clientes" runat="server" style="z-index: 1; left: 448px; top: 69px; position: absolute" Visible="False">
        </asp:DropDownList>
    </form>
</body>
</html>
