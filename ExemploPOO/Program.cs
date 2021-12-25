using System;
using ExemploPOO.Models;
using ExemploPOO.Interface;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "Subspasta teste 3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo.teste.txt");
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            
            FileHelper helper = new FileHelper();
            helper.CriarArqTextoStream(caminhoArquivo, listaString);

           //helper.CriarArqTexto(caminhoArquivo, "Hello, World!");

            //helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarDiretorio(caminhoPathCombine);

            // helper.ListarArquivosDiretorios(caminho);

            // helper.ListarDiretorios(caminho);



            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir(21, 3));

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


