using tabuleiro;

namespace Xadrez
{
    class posicaoXadrez
    {
        #region Propriedades

        public char coluna { get; set; }
        public int linha { get; set; }

        #endregion

        #region Construtor

        public posicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        #endregion

        #region Métodos
        
        public Posicao ToPosisao() 
        {
            return new Posicao(8 - linha,coluna-'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

        #endregion
    }
}
