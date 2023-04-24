<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_01_Introducao_a_Aplicacao_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBoxMensagem" runat="server"></asp:TextBox>
            <asp:Button ID="BtnMensagem" runat="server" Height="23px" Text="Mostrar Mensagem" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
