using System;
using System.Text;

namespace ProjetoStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string texto = "Meu Texto";

            texto += " extendido";
            texto += " ao infinito";
            texto += " e além do ALUNO";

            Console.WriteLine(texto.Replace("ALUNO", "João"));
            Console.WriteLine(texto);

            StringBuilder mensagem = new StringBuilder();

            mensagem
              .AppendLine("Meu Texto")
              .AppendLine(" extendido")
              .AppendLine(" ao infinito")
              .AppendLine(" e além do ALUNO");

            mensagem.Replace("ALUNO", "João");

            Console.WriteLine(mensagem.ToString());

            new StringBuilder()
                .AppendLine("Meu Texto")
            .AppendLine(" extendido")
            .AppendLine(" ao infinito")
            .AppendLine(" e além do ALUNO")
            .ToString();

            Console.ReadKey();
        }
        
    }
}
