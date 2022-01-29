namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posic { get; set; }
        public Cor Cor { get; protected set; }
        public int QtddMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posic = null;
            Tab = tab;
            Cor = cor;
            QtddMovimentos = 0;
        }

        public void IncrementaQtddMovimentos()
        {
            QtddMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
