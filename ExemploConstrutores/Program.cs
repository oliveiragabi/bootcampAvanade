using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = log.GetInstance();
            log.PropriedadeLog = "Teste instancia";

            Log log2 = log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);
            // Pessoa p1 = new Pessoa("Gabi", "Souza");
            // p1.Apresentar();
        }
    }
}