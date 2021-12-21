using AppConsoleJogoXadrez;
using System;
using tabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        #region Propriedades

        public Tabuleiro tab { get; private set; }
        
        public int turno { get; private set; }

        public Cor jogadorAtual { get; private set; }

        public bool terminada { get; private set; }

        #endregion

        #region Construtor

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        #endregion

        #region Métodos

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        public void realizaJogada(Posicao origem, Posicao destino) 
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoOrigem(Posicao pos) 
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Ñão existe peça na possição de origem escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peça escolhida não é a sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Ñão há movimentos possivel para a peça de origem escolhida!");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).movimentoPossivel(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void mudaJogador() 
        {
            if (jogadorAtual==Cor.Branca)
            {
                jogadorAtual = Cor.preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
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

        #endregion

    }
}
