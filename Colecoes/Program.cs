using System;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {   
            OperacoesArrays op = new OperacoesArrays();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };
            int[] arrayCopia = new int[10];

            // System.Console.WriteLine("Array original: ");
            // op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado: ");
            // op.ImprimirArray(array);

            System.Console.WriteLine("Array antes da copia: ");
            op.ImprimirArray(arrayCopia);

            op.Copiar(ref array, ref arrayCopia);
            System.Console.WriteLine("Array após a copia: ");
            op.ImprimirArray(arrayCopia);
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