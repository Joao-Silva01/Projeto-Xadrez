namespace tabuleiro
{
    internal class Posicao
    {
        public double linha { get; set; }
        public double coluna { get; set; }

        public Posicao(double linha, double coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha + ", " + coluna;
        }
    }
}
