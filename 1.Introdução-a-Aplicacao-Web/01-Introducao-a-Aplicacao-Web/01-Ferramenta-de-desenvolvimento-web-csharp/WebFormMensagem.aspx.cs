using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_Introducao_a_Aplicacao_Web
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