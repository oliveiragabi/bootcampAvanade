using System; 

namespace Colecoes.Helper
{
    public class OperacoesArrays
    {
        
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for(int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        //temp recebe  a prox posicao
                        temp = array[j + 1];

                        //troca o proximo com o atual
                        array[j + 1] = array[j];

                        //atual recebe temporario
                        array[j] = temp;
            
                    }
                }

            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(",", array);
            System.Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }
    }
}