using AppConsoleJogoXadrez;
using System;
using tabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        
        private int turno;

        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('c',1).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('c',2).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('d',2).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('e',2).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new posicaoXadrez('e',1).ToPosisao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new posicaoXadrez('d',1).ToPosisao());

            tab.colocarPeca(new Torre(tab, Cor.preta), new posicaoXadrez('c',7).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.preta), new posicaoXadrez('c',8).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.preta), new posicaoXadrez('d',7).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.preta), new posicaoXadrez('e',7).ToPosisao());
            tab.colocarPeca(new Torre(tab, Cor.preta), new posicaoXadrez('e',8).ToPosisao());
            tab.colocarPeca(new Rei(tab, Cor.preta), new posicaoXadrez('d',8).ToPosisao());
        }
    }
}
