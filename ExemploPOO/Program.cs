using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno p1 = new Aluno();
            p1.Idade = 7;
            p1.Nome = "Gabi";

            p1.Apresentar();

            // Retangulo re = new Retangulo();
            // re.DefinirMedidas(30, 30);
            
            // System.Console.WriteLine($"Área: (re.ObterArea())");

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Gabi";
            // p1.Idade = 21;

            // p1.Apresentar();
         
        }
    }
}


