using System;
using Colecoes.Helper;
using System.Collections.Generic;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {   
            Dictionary<string, string> estados = new Dictionary<string, string>();
            estados.Add("SP", "São Paulo");
            estados.Add("MG", "Minas Gerais");
            estados.Add("BA", "Bahia");

            foreach (KeyValuePair<string, string> item in estados)
            {
                //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string valorProcurado = "BA";
            //var teste = estados["SC"];

            if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            {
                System.Console.WriteLine(estadoEncontrado);
            }
            else
            {
                System.Console.WriteLine($"Chave: {valorProcurado} não existe no dicionário.");
            }
            // System.Console.WriteLine($"Removendo valor: {valorProcurado}");
            // estados.Remove(valorProcurado);
            
            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // System.Console.WriteLine("Valor original: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - teste atualização";

            // System.Console.WriteLine("Valor atualizado: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".net");
            // pilhaLivros.Push("clear code");
            // pilhaLivros.Push("BDD");

            // System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

            // while (pilhaLivros.Count > 0)
            // {
            //      System.Console.WriteLine($"Proximo livro p/ leitura: {pilhaLivros.Peek()}");
            //      System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Gabi");
            // fila.Enqueue("Ruan");
            // fila.Enqueue("Lara");
            // fila.Enqueue("Luana");
            // fila.Enqueue("Mary");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de {fila.Peek()}");
            //     System.Console.WriteLine($"Vez de {fila.Dequeue()} atendido");
            // }


            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>() { "AM", "PE", "MA" };
            // string[] estadosArray = new string[2] { "SP", "RJ" };

            // System.Console.WriteLine($"A qtd de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // // System.Console.WriteLine("Removendo o elemento");
            // // estados.Remove("AM");

            // // estados.AddRange(estadosArray);

            // estados.Insert(1, "AC");

            // opLista.ImprimirListaString(estados);
            
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