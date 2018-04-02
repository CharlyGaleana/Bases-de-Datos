<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminUsuarios.aspx.cs" Inherits="AdminUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Administración de usuarios</title>
    <style type="text/css">
        #form1 {
            height: 490px;
        }
        .auto-style1 {
            z-index: 1;
            left: 269px;
            top: 254px;
            position: absolute;
        }
        .auto-style2 {
            position: absolute;
            top: 152px;
            left: 22px;
            z-index: 1;
            width: 38px;
        }
        .auto-style3 {
            width: 707px;
            height: 38px;
            position: absolute;
            top: 396px;
            left: 11px;
            z-index: 1;
        }
        .auto-style4 {
            z-index: 1;
            left: 472px;
            top: 297px;
            position: absolute;
        }
        .auto-style5 {
            position: absolute;
            top: 149px;
            left: 43px;
            z-index: 1;
            width: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFCC99">
    <div style="background-color: #FFCC99; height: 474px; z-index: 1; left: 10px; top: 15px; position: absolute; width: 707px;">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 226px; top: 34px; position: absolute; width: 220px" Text="Administración de usuarios"></asp:Label>
        <asp:Button ID="BtnAlta" runat="server" style="z-index: 1; left: 69px; top: 81px; position: absolute" Text="Alta de usuarios" OnClick="BtnAlta_Click" />
        <asp:Button ID="BtnBaja" runat="server" style="z-index: 1; left: 267px; top: 81px; position: absolute" Text="Baja de usuarios" OnClick="BtnBaja_Click" />
        <asp:Button ID="BtnCambio" runat="server" style="z-index: 1; left: 465px; top: 80px; position: absolute" Text="Cambio de datos" />
        <asp:TextBox ID="TxtRFC" runat="server" style="z-index: 1; left: 75px; top: 150px; position: absolute" Visible="False" CausesValidation="True" ValidationGroup="AllValidators">RFC</asp:TextBox>
        <asp:TextBox ID="TxtNombre" runat="server" style="z-index: 1; left: 75px; top: 199px; position: absolute" Visible="False">Nombre</asp:TextBox>
        <asp:TextBox ID="TxtPassw" runat="server" style="z-index: 1; left: 75px; top: 254px; position: absolute" Visible="False">Contraseña</asp:TextBox>
        <asp:DropDownList ID="DDLTipo" runat="server" style="z-index: 1; left: 75px; top: 304px; position: absolute" Visible="False" AutoPostBack="True" OnSelectedIndexChanged="DDLTipo_SelectedIndexChanged">
            <asp:ListItem>Tipo de usuario</asp:ListItem>
            <asp:ListItem Value="Cli">Cliente</asp:ListItem>
            <asp:ListItem Value="Emp">Empleado</asp:ListItem>
            <asp:ListItem Value="Ger">Gerente</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="LblMensaje" runat="server" style="z-index: 1; left: 75px; top: 354px; position: absolute" Text="Operación: en espera"></asp:Label>
        <asp:DropDownList ID="DDLUsuarios" runat="server" style="z-index: 1; left: 269px; top: 149px; position: absolute" Visible="False" AutoPostBack="True" OnSelectedIndexChanged="DDLUsuarios_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:TextBox ID="TxtDomicilio" runat="server" style="z-index: 1; left: 270px; top: 198px; position: absolute; width: 131px" Visible="False">Domicilio</asp:TextBox>
        <asp:TextBox ID="TxtCat" runat="server" Visible="False" Enabled="False" CssClass="auto-style1">Categoría</asp:TextBox>
        <asp:Button ID="BtnEjecuta" runat="server" Enabled="False" OnClick="BtnEjecuta_Click" Text="Ejecutar operación" CssClass="auto-style4" ValidationGroup="AllValidators" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtRFC" CssClass="auto-style5" ErrorMessage="Formato: A0" ValidationExpression="\w{4}\d{6}(\w|\d){3}" ValidationGroup="AllValidators">*</asp:RegularExpressionValidator>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" style="z-index: 1; left: 474px; top: 355px; position: absolute">Página inicial</asp:HyperLink>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtRFC" CssClass="auto-style2" ErrorMessage="Dar un RFC Correcto" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style3" ValidationGroup="AllValidators" />
    
    </div>
    </form>
</body>
</html>
