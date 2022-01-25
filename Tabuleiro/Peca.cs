namespace tabuleiro
{
    class Peca
    {
        public Posicao Posic { get; set; }
        public Cor Cor { get; protected set; }
        public int QtddMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            Posic = posicao;
            Tab = tab;
            Cor = cor;
            QtddMovimentos = 0;
        }


    }
}
