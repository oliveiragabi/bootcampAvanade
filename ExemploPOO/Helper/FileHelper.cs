using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios (string caminho)
        {
            var retornoArquivo = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivo)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivo)
        {
            Directory.Delete(caminho, apagarArquivo);
        }

        public void CriarArqTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);

            }
        }

    }

}