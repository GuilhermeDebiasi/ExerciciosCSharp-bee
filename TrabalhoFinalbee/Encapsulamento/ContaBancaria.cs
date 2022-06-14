using System;

namespace Encapsulamento.Entidades
{
    internal class ContaBancaria
    {
        #region
        private Entidades.ContaBancaria _contaBancaria;

        #endregion Atributos

        #region Construtores
       
        public ContaBancaria(Entidades.ContaBancaria contaBancaria)
        {
            _contaBancaria = contaBancaria;
        }

        #endregion Construtores

        #region Metodos Publicos

        public void Depositar(decimal valor)

            public decimal ObterSaldoAtual()
        {
            return _contaBancaria.Saldo();
        }
        public void Sacar(decimal valor);







    }
    #endregion Metodos Publicos
}
