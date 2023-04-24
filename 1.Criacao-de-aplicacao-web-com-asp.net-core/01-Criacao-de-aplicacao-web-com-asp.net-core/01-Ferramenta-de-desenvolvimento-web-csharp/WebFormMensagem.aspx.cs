using System;

namespace _01_Introducao_a_Aplicacao_Web._01_Ferramenta_de_desenvolvimento_web_csharp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnMensagem(object sender, EventArgs e)
        {

        }

        protected void ButtonMensagem_Click(object sender, EventArgs e)
        {
            Response.Write("Olá " + TextBoxMensagem.Text);
            Response.Write("<script>alert('Olá"+TextBoxMensagem.Text +"')</script> ");
        }
    }
}