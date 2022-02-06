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

        public void DecrementaQtddMovimentos()
        {
            QtddMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i =0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j< Tab.Linhas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

       public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
