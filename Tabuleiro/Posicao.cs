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

        public override string ToString()
        {
            return linha 
                + ", " 
                + coluna;
        }
    }
}
