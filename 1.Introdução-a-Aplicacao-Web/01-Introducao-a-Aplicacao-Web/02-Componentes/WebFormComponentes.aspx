<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormComponentes.aspx.cs" Inherits="_01_Introducao_a_Aplicacao_Web._02_Componentes.WebForm1" %>

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
            
            <br />
            <br />
            <br />
            <asp:DropDownList ID="ddlContatos" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="height: 22px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <select id="selectTagHtml">
               <% foreach (var contato in Contatos)
                   {%>
                    <option value="<%=contato.ID%>"><%=contato.Nome%></option>
                <%} %>--%>
            </select>
           
        </p>
    </form>
</body>
</html>
