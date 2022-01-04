using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> Lista)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                System.Console.WriteLine($"Indice {i}, Valor: {Lista[i]}");
            }
        }
    }
}