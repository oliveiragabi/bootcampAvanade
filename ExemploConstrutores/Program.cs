using System;
using ExemploConstrutores.Models;


namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            Matematica mat = new Matematica(10, 20);
            mat.Somar();
            
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(10,25);

            // Data data = new Data();
            // //data.SetMes(2);

            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            
            // Pessoa p1 = new Pessoa("Gabi", "Souza");
            // p1.Apresentar();

            // Aluno a1 = new Aluno("Gabi", "Souza", "Matematica");
            // a1.Apresentar();
        }
    }
}