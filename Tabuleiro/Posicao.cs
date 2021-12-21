namespace tabuleiro
{
    class Posicao
    {
        #region Propriedades

        public int linha { get; set; }

        public int coluna { get; set; }

        #endregion

        #region Construtor

        public Posicao(int Linha, int Coluna)
        {
            this.linha = Linha;
            this.coluna = Coluna;
        }

        #endregion

        #region Métodos

        public void definirValores(int linha, int coluna) 
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha 
                + ", " 
                + coluna;
        }

        #endregion

    }
}
