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
        <asp:Table ID="Table1" runat="server" BorderColor="Black" BorderStyle="Solid" style="z-index: 1; left: 152px; top: 79px; position: absolute; height: 25px; width: 453px">
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
    
    </div>
    </form>
</body>
</html>
