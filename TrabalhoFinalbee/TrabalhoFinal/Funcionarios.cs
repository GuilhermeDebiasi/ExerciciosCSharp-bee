
namespace TrabalhoFinal
{
    internal class Funcionarios
    {
        public int Nome { get; set; }
        public int Sobrenome { get; set; }
        public int Salario { get; set; }

        public virtual string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";

        }
    }
   
    
}

