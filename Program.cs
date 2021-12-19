using System;
using tabuleiro;
using Xadrez;

namespace AppConsoleJogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('c', 7);
            Console.WriteLine(posicaoXadrez);
            Console.WriteLine(posicaoXadrez.ToPosisao());

            Console.ReadLine();
        }
    }
}
