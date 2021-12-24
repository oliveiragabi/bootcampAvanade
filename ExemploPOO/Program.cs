using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Gabi";
        p1.Idade = 21;

        p1.Apresentar();


        Console.WriteLine("Hello, World!");
         
        }
    }
}


