namespace TrabalhoFinalCorrigido.Entidades
{
    public class Professor : Funcionario
    {
        
        public string Curso { get; set; }

        #region Construtores

        public Professor(int numero) :base(numero)
        { 
        }

        #endregion Construtores

        #region Métodos

        public override decimal ObterPercentualReajuste()
        {
            return 20m;
        }

        #endregion Métodos
    }
}
