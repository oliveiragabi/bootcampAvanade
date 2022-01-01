using System;


namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {        
            int[] arrayInt = new int[3];
            arrayInt[0] = 10;
            arrayInt[1] = 5;
            arrayInt[2] = 6;

            System.Console.WriteLine("Percorrendo array");
            
            for (int i = 0; i < arrayInt.Length; i++)
            {
                System.Console.WriteLine(arrayInt[i]);
            }
        }
         
    }
}