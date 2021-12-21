using tabuleiro;

namespace Xadrez
{
    class posicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public posicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao ToPosisao() 
        {
            return new Posicao(8 - linha,coluna-'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
