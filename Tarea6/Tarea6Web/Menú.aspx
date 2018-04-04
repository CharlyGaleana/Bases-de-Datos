<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menú.aspx.cs" Inherits="Menú" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 385px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #009933">
    <div style="height: 323px; background-color: #009933;">
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 55px; top: 52px; position: absolute" Text="Elige alguna de las siguientes opciones:"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 318px; top: 98px; position: absolute" Text="Datos Cliente y Pedidos" />
    
    </div>
    </form>
</body>
</html>
