using System;
using tabuleiro;
using Xadrez;

namespace AppConsoleJogoXadrez
{
    /// <summary>
    /// Projeto Udemy - Criação de um jogo de Xadrez.
    /// Aplicando técnicas de Programação orientada a objetos (POO).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Console.Title = "Projeto Udemy - Jogo de Xadrez";
                        Tela.imprimirPartida(partida);
                        
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosisao();
                        partida.validarPosicaoOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosisao();
                        partida.validarPosicaoDeDestino(origem,destino);
                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);

                        //Incluido Console.ReadLine() para "Travar a mensagem de erro na tela".
                        Console.ReadLine(); 
                    }
                }

                Console.Clear();
                Tela.imprimirPartida(partida);

                // Incluido para travar a tela.
                Console.ReadLine(); 
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
