using System;


namespace TesteOrientacoesObjeto
{
    internal class veiculo
    {
        public int VelocidadeAtual { get; private set; }

        private bool VeiculoEstaLigado { get; private set; }

        private void FreiarCarro()
        {
            VelocidadeAtual = 0;
        }

        public void LigarCarro()
        {       
            VeiculoEstaLigado = true;
        }
        public void DesligarCarro()
        {

            if (VelocidadeAtual > 0)
                 FreiarCarro();
                
            VeiculoEstaLigado = false;
            
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
