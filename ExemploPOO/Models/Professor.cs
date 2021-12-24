using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, minha idade é {Idade} anos. Sou professor, meu documento é: {Documento} e meu salário é: {Salario}");
        }
    }
}