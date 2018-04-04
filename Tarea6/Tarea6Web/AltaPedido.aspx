<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltaPedido.aspx.cs" Inherits="AltaPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 254px">
    <form id="form1" runat="server" style="background-color: #33CCFF; height: 363px;">
    <div style="font-size: 20px">
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 504px; top: 17px; position: absolute; height: 67px; width: 132px" Text="Alta de Pedidos"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Agregar Artículos"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Artículo:  "></asp:Label>
        <asp:DropDownList ID="Articulos" runat="server" style="z-index: 1; left: 74px; top: 72px; position: absolute">
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Cantidad:  "></asp:Label>
            <asp:TextBox ID="Cantidad" runat="server" style="z-index: 1; left: 72px; top: 113px; position: absolute; width: 83px"></asp:TextBox>
        </p>
        <asp:Button ID="Articulo" runat="server" Text="Agregar Articulo" OnClick="Articulo_Click" />
        <asp:GridView ID="Detalles" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Id" />
                <asp:BoundField HeaderText="Nombre" />
                <asp:BoundField HeaderText="Precio" />
                <asp:BoundField HeaderText="Cantidad" />
                <asp:BoundField HeaderText="Monto Total" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
