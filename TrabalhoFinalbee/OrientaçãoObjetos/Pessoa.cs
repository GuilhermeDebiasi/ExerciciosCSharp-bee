using System;

namespace classe
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

        public void ExibirNomeCompleto()
        {
            Console.WriteLine($"{nome} {sobrenome}");
        }
       
        public void ExibirFaixaIdade()
        {
            

            if (idade >= 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("De menor");
        }
    

}
}
