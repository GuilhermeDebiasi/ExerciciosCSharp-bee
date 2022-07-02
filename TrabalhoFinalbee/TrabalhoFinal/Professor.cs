
namespace TrabalhoFinal
{
    internal class Professor : Funcionarios
    {
 
        public int Curso { get; set; }

        public override string ObterNomeCompleto()
        {
            return $"{base.ObterNomeCompleto()}";
        }
    }
}
