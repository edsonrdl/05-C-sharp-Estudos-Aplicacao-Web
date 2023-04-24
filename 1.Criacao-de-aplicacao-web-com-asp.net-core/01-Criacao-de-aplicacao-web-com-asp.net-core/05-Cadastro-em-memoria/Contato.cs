namespace _01_Introducao_a_Aplicacao_Web._05_Cadastro_em_memoria
{
    public class Contato
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}