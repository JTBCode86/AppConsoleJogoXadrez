﻿using System;
using tabuleiro;

namespace AppConsoleJogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
