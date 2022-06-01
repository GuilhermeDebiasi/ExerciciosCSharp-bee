using System;

namespace classe
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

       
        public void ExibirFaixaIdade()
        {
             
            
            if (idade == 0)
                Console.WriteLine("Idade não informada");
            else if (idade >= 18)
                Console.WriteLine("Maior de menor");
            else
                Console.WriteLine("De menor");
        }
        public void ExibirNomeCompleto()
        {
            Console.WriteLine($"{nome} {sobrenome}");
        }
        
    } 
}
