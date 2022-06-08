using System;


namespace frota
{
    public class Veiculo
    {
        public string placa, marca, modelo;
        public Motorista proprietario;

        public string ObterDescricao()
        {

            return $"{modelo} ({placa})";

        }
        public static ObterNomeProprietario()
        {
            if (proprietario != null)
                return proprietario.ObterNomeCompleto();

            return string.Empty;
        }



    }
}
   
    
       
    

