namespace TrabalhoFinalCorrigido.Entidades
{
    public abstract class Funcionario
    {
        #region Atributos

        public int Numero { get; private set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public decimal Salario { get; set; }

        #endregion Atributos

        #region Construtores

        public Funcionario(int numero)
        {
            Numero = numero;
        }

        #endregion Construtores

        #region Métodos

        public string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }

        public abstract decimal ObterPercentualReajuste();
        
        #endregion Métodos
    }
}
