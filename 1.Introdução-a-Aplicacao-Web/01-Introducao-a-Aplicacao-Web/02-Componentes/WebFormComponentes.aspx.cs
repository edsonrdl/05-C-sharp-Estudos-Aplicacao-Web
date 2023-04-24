using System;

namespace _01_Introducao_a_Aplicacao_Web._02_Componentes
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
            Response.Write("Olá " + Request["TextBoxMensagem"]);
            Response.Write("telefone " + Request["telefoneID"] + telefoneID.Value);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}