using System;


namespace Encapsulamento.Entidades
{
    public class Pessoa
    {

        #region Propriedades

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        #endregion Propiedades

        #region Métodos Públicos


        public string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }

            #endregion Métodos Públicos



    }

}
