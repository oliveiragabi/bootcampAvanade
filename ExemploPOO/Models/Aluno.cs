using System;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

       
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, minha idade é {Idade} anos. Minha nota é {Nota} e meu documento é: {Documento}");
        }
    }
}