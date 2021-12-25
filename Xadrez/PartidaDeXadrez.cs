using System.Collections.Generic;
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

        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        #endregion

        #region Construtor

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
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

            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }
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

        public HashSet<Peca> pecasCapituradas(Cor cor) 
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor==cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor) 
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapituradas(cor));
            return aux;
        }

        public void colocarNovaPeca(char coluna, int linha,Peca peca) 
        {
            tab.colocarPeca(peca, new posicaoXadrez(coluna, linha).ToPosisao());
            pecas.Add(peca);
        }

        private void colocarPecas()
        {
            colocarNovaPeca('c',1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('c',2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('d',2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('e',2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('e',1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('d',1, new Rei(tab, Cor.Branca));

            colocarNovaPeca('c',7, new Torre(tab, Cor.preta));
            colocarNovaPeca('c',8, new Torre(tab, Cor.preta));
            colocarNovaPeca('d',7, new Torre(tab, Cor.preta));
            colocarNovaPeca('e',7, new Torre(tab, Cor.preta));
            colocarNovaPeca('e',8, new Torre(tab, Cor.preta));
            colocarNovaPeca('d',8, new Rei(tab, Cor.preta));

        }

        #endregion

    }
}
