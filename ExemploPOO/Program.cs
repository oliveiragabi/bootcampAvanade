﻿using System;
using ExemploPOO.Models;
using ExemploPOO.Interface;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Dividir(21, 3));
            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Result. da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Result. da primeira soma: " + calc.Somar(10, 10, 10));

            // Professor p1 = new Professor();
            // p1.Idade = 21;
            // p1.Nome = "Ruan";
            // p1.Salario = 7000;
            // p1.Documento = "2102825";

            // p1.Apresentar();

            // Aluno p1 = new Aluno();
            // p1.Idade = 21;
            // p1.Nome = "Gabi";
            // p1.Nota = 7;
            // p1.Documento = "2102825";

            // p1.Apresentar();

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


