<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aplicaciòn Web - BD</title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #CC99FF; height: 363px;">
    <div style="background-color: #99CCFF; height: 346px;">
    

        <asp:Label ID="LblFecha" runat="server" Text="Label"></asp:Label>


        <asp:Login ID="Login2" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" OnAuthenticate="Login2_Authenticate" style="z-index: 1; left: 393px; top: 101px; position: absolute; height: 134px; width: 202px" TextLayout="TextOnTop">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
        </asp:Login>


        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 51px; top: 55px; position: absolute" Text="Inicia sesión para acceder al menú inicial"></asp:Label>


    </div>
    </form>
    </body>
    

</html>
