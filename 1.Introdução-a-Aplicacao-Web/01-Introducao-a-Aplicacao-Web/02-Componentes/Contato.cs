using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01_Introducao_a_Aplicacao_Web._02_Componentes
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