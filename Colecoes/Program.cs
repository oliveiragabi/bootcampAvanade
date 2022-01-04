using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {   
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>() { "AM", "PE", "MA" };
            string[] estadosArray = new string[2] { "SP", "RJ" };

            System.Console.WriteLine($"A qtd de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("AM");

            // estados.AddRange(estadosArray);

            estados.Insert(1, "AC");

            opLista.ImprimirListaString(estados);
            
        //     OperacoesArrays op = new OperacoesArrays();
        //     int[] array = new int[5] { 6, 3, 8, 1, 9 };
        //     int[] arrayCopia = new int[10];
        //     string[] arrayString = op.ConverterParaArrayString(array);

        //   // int valorProcurado = 8;
        //     System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

        //     op.RedimensionarArray(ref array, array.Length * 2);
        //     System.Console.WriteLine($"Capacidade atual do array após red: {array.Length}");
        //     // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice >-1 )
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array.");
            // }
            // int valorAchado = op.ObterValor(array, valorProcurado);
            
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor!");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor :(");
            // }

            // bool todosMaioresQue = op.TodosMaiorQue(array, valorProcurado);
            
            // if(todosMaioresQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existem valores que não são maiores que: {0}", valorProcurado);
            // }

            // bool existe = op.Existe(array, 1);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original: ");
            // op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado: ");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da copia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a copia: ");
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int [4, 2]
            // {
            //     { 8 , 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 }
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }     
            // int[] arrayInt = new int[3];
            // arrayInt[0] = 10;
            // arrayInt[1] = 5;
            // arrayInt[2] = 6;

            // System.Console.WriteLine("Percorrendo array");
            
            // for (int i = 0; i < arrayInt.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInt[i]);
            // }
        }
         
    }
}