using System;
using System.Collections.Generic;

namespace _01_Introducao_a_Aplicacao_Web._05_Cadastro_em_memoria
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Contato> Contatos = new List<Contato>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Contatos.Add(new Contato() {Nome = "Luffy",ID = 1});
            Contatos.Add(new Contato() {Nome = "Zoro",ID = 2});
            Contatos.Add(new Contato() {Nome = "Sanji",ID = 4});
           
            ddlContatos.DataSource = Contatos;
            ddlContatos.DataValueField = "Id";
            ddlContatos.DataTextField = "Nome";
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
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

 
}