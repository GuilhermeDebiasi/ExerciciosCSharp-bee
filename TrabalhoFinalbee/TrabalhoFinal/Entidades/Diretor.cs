namespace TrabalhoFinalCorrigido.Entidades
{
    public  class Diretor : Funcionario
    {

        #region Construtores

        public Diretor(int numero) : base(numero)
        {

        }

        #endregion Construtores

        #region Métodos

        public override decimal ObterPercentualReajuste()
        {
            return 30m;
        }

        #endregion Métodos
    }
}
