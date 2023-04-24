using System;
using System.Collections.Generic;

namespace _2.Conceitos_basicos_de_desenvolvimento_web._06_HTTP_HTTPS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<string> Contatos = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Contatos.Add("Luffy");
            Contatos.Add("Zoro");
            Contatos.Add("Sanji");
            ddlContatos.DataSource = Contatos;
            ddlContatos.DataBind();
        }

        protected void BtnMensagem(object sender, EventArgs e)
        {
           
            
        }

        protected void ButtonMensagem_Click(object sender, EventArgs e)
        {
            Response.Write("Olá " + Request["TextBoxMensagem"]);
            Response.Write("telefone " + Request["telefoneID"] + telefoneID.Value);

        }
    }
}