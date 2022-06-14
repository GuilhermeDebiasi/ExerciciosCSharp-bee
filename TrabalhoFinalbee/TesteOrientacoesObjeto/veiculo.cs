using System;


namespace TesteOrientacoesObjeto
{
    internal class veiculo
    {
        public int VelocidadeAtual { get; set; }

        private bool VeiculoEstaLigado;

        private void FrearCarro()
        {
            VelocidadeAtual = 0;
        }

        public void LigarCarro()
        {       
            VeiculoEstaLigado = true;
        }
        public void DesligarCarro()
        {

            if (VelocidadeAtual == 0)
            {
                FrearCarro();
                VeiculoEstaLigado = false;
            }
        }
        public bool TesteLigado()
        {
            return VeiculoEstaLigado;

        }

        public int AcelerarVeiculo(int acelerar)
        {
            if (VelocidadeAtual <= 100)
            {
                VelocidadeAtual = acelerar;
            }
            return VelocidadeAtual;
        }
    }

}
