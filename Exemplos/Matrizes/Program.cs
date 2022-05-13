using System;

namespace Matrizes
{
    internal class Program
    {
        static int[,] jogo;
        const int LINHAS = 3, COLUNAS = 3;
        static void Main(string[] args)
        {

            jogo = new int[LINHAS, COLUNAS];
            IniciarTabuleiro();

            int contador = 0;

            int quemJoga = 1;
            bool continuarJogando = true;
            bool checarGanhador, checarEmpate;
            string posicaoJogada;

            while (continuarJogando) //laço do jogo
            { 
               
                // imprimir tabuleiro
                ImprimirTabuleiro();
                // ler quem joga
                posicaoJogada = LerPosicaoJogador(quemJoga);

                // registrar posição da jogada
                RegistrarPosicaoJogador(quemJoga, posicaoJogada);

                // chegar se ganhou
                checarGanhador = ChecarGanhador(quemJoga);

                // checar empate
                if (checarGanhador == false)
                {
                    checarEmpate = ChecarEmpate();
                    if(checarEmpate == true)
                    {
                        Console.WriteLine("Houve empate!");
                        continuarJogando = false;
                    }
                }
                else
                {
                    Console.WriteLine($"Jogador {quemJoga} é o vencedor!");
                    continuarJogando = false;
                }

                // alterar quem joga
                if(quemJoga == 1)
                {
                    quemJoga = 2;
                }else if (quemJoga == 2)
                {
                    quemJoga = 1;
                }

                
            }
            ImprimirTabuleiro();
        }

        static bool ChecarEmpate()
        {
            for (int i = 0; i < LINHAS; i++)
            {
                for (int j = 0; j < COLUNAS; j++)
                {
                    if(jogo[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
                    return true;
        }



        static bool ChecarGanhador(int quemJoga)
        {
            if(jogo[0 , 0] == quemJoga && jogo[0, 1] == quemJoga && jogo[0,2] == quemJoga)
            {
                return true;
            }
            else if (jogo[1, 0] == quemJoga && jogo[1, 1] == quemJoga && jogo[1,2] == quemJoga)
            {
                return true;
            }
            else if (jogo[2, 0] == quemJoga && jogo[2, 1] == quemJoga && jogo[2,2] == quemJoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemJoga && jogo[1, 0] == quemJoga && jogo[2,0] == quemJoga)
            {
                return true;
            }
            else if (jogo[0, 1] == quemJoga && jogo[1, 1] == quemJoga && jogo[2,1] == quemJoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemJoga && jogo[1, 2] == quemJoga && jogo[2,2] == quemJoga)
            {
                return true;
            }
            else if (jogo[0, 0] == quemJoga && jogo[1, 1] == quemJoga && jogo[2,2] == quemJoga)
            {
                return true;
            }
            else if (jogo[0, 2] == quemJoga && jogo[1, 1] == quemJoga && jogo[2,0] == quemJoga)
            {
                return true;
            }
            return false;

        }

        static void RegistrarPosicaoJogador(int quemJoga, string posicaoJogada)
        {
            int x, y;
            var posicoes = posicaoJogada.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);

            jogo[x, y] = quemJoga;
        }



        static string LerPosicaoJogador(int quemJoga)
        {
            Console.WriteLine($"Jogador {quemJoga} é a sua vez! Escolha sua posição");
            string linha;
            int x, y;
            /*
             * 0 0 | 0 1 | 0 2
             * 1 0 | 1 1 | 1 2
             * 2 0 | 2 1 | 2 2
             */
            linha = Console.ReadLine(); // 0 2
            var posicoes = linha.Split(' ');
            int.TryParse(posicoes[0], out x);
            int.TryParse(posicoes[1], out y);

            if(jogo[x, y] == 0)
            {
                // posição não jogada
                return linha;
            }

            return "";
        
        }

       static void IniciarTabuleiro()
        {
            for (int i = 0; i < LINHAS; i++)
            {
                for (int j = 0; j < COLUNAS; j++)
                {
                    jogo[i, j] = 0;
                    
                     
                }
            }
        }

        static void ImprimirTabuleiro()
        {
            Console.WriteLine("Tabuleiro");
            for (int i = 0; i < LINHAS; i++)
            {
                for (int j = 0; j < COLUNAS; j++)
                {
                    if (jogo[i, j] == 0)
                    {
                        Console.Write("   ");
                    }
                    else if (jogo[i, j] == 1)
                    {
                        Console.Write(" X ");
                    }
                    else if (jogo[i, j] == 2)
                    {
                        Console.Write(" O ");
                    }
                    if(j == 0 || j == 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if(i == 0 || i == 1)
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }


    }
}