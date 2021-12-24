using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e minha idade é {Idade} anos");
        }
    }
}