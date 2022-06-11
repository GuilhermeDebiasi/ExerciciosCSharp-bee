using System;

namespace Encapsulamento.Serviços

{
    internal class ContaBancaria
    {
        #region Atributos
        private Entidades.ContaBancaria _contaBancaria;

        #endregion Construtores

        #region Construtores

        public ContaBancaria(Entidades.ContaBancaria contaBancaria)
        {
            _contaBancaria = contaBancaria;
        }

        #endregion
        #region Metodos Publicos

        public void Depositar(decimal valor)
        {
            _contaBancaria.Saldo += valor;
        }

        public decimal ObterSaldoAtual()
        {
            return _contaBancaria.Saldo();
        }
        public void Sacar(decimal valor)
        {
            _contaBancaria.Saldo += valor;
        }







    }
    #endregion Metodos Publicos
}
