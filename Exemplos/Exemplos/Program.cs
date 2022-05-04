using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolver uma caluculadora
             * que vai ler um numero
             * depois ler o segundo numero 
             * depois vai ler o operador
             * como resposta o programa vai
             * responder o resultado da operação
             */
            // ler o primeiro numero
            // ler o segundo numero
            // ler o operador + - * /
            // verificar o tipo do operador
            // realizar a operação conforme o tipo verificado
            // imprimir o resultado

            double numero1, numero2;
            double resultado;
            string operador = "";
            
            resultado = 0;


            while (operador != "0")

            {
                Console.WriteLine("Digite o primeiro numero: ");
                Double.TryParse(Console.ReadLine(), out numero1);

                Console.WriteLine("Digite o segundo numero: ");
                Double.TryParse(Console.ReadLine(), out numero2);


                while (operador != "0")

                {
                    Console.WriteLine("Digite o operador: ");
                    operador = Console.ReadLine();



                    if (operador != "*" && operador != "/" && operador != "+" && operador != "-")
                    {
                        Console.WriteLine("Operador invalido: ");
                        continue;
                    }

                    else
                    {
                        break;
                    }
                }

                    if (operador == "0")
                {
                    break;

                }

                if (operador == "+")
                {

                    resultado = numero1 + numero2;
                }


                if (operador == "-")
                {

                    resultado = numero1 - numero2;
                }


                if (operador == "*")
                {

                    resultado = numero1 * numero2;
                }


               if (operador == "/")
                {
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por zero");
                        continue;
                    }


                    else
                    {
                        resultado = numero1 / numero2;
                    }
                }



                Console.WriteLine("Seu resultado e:");
                Console.WriteLine(resultado);


            }
        }
    }
}