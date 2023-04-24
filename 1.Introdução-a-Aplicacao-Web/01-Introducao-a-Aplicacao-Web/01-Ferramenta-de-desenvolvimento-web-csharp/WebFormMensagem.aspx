<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMensagem.aspx.cs" Inherits="_01_Introducao_a_Aplicacao_Web.WebForm1" %>

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
            <asp:TextBox ID="TextBoxMensagem" runat="server" Width="320px"></asp:TextBox>
            <asp:Button ID="ButtonMensagem" runat="server" OnClick="ButtonMensagem_Click" Text="Enviar Mensagem" Width="210px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
