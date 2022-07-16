namespace TrabalhoFinalCorrigido.Servicos
{
   public class Funcionario
    {
        public void ReajustarSalario(Entidades.Funcionario funcionario)
        {
            decimal valorReajuste = funcionario.Salario * (funcionario.ObterPercentualReajuste() / 100);

            funcionario.Salario = funcionario.Salario + valorReajuste;
        }
   }
}
