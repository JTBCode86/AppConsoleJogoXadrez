namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int Linha, int Coluna)
        {
            this.linha = Linha;
            this.coluna = Coluna;
        }

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
    }
}
