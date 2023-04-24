<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormHttpHttps.aspx.cs" Inherits="_2.Conceitos_basicos_de_desenvolvimento_web._06_HTTP_HTTPS.WebForm1" %>

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
            <%--<input type="text" name="telefone" value="<%=Request["telefone"]%>"/>--%>
            <input type="text" id="telefoneID" name="telefone" runat="server" />
            <asp:Button ID="ButtonMensagem" runat="server" OnClick="ButtonMensagem_Click" Text="Enviar Mensagem" Width="210px" />
          
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
