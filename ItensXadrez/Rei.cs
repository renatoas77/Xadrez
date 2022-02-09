using System;
using tabuleiro;

namespace ItensXadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez Partida;

        public Rei(Tabuleiro tab, Cor cor,PartidaDeXadrez partida) : base(tab, cor)
        {
            Partida = partida; 
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool TestTorreParaRoque(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QtddMovimentos == 0;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima 
            pos.DefinirValores(Posic.Linha - 1, Posic.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo 
            pos.DefinirValores(Posic.Linha + 1, Posic.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita 
            pos.DefinirValores(Posic.Linha, Posic.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.DefinirValores(Posic.Linha, Posic.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //nordeste
            pos.DefinirValores(Posic.Linha - 1, Posic.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.DefinirValores(Posic.Linha - 1, Posic.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudeste
            pos.DefinirValores(Posic.Linha + 1, Posic.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(Posic.Linha + 1, Posic.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // #jogada especial roque
            if(QtddMovimentos == 0 && !Partida.Xeque)
            {
                Posicao posT1 = new Posicao(Posic.Linha, Posic.Coluna + 3); 
                if (TestTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posic.Linha, Posic.Coluna + 1);
                    Posicao p2 = new Posicao(Posic.Linha, Posic.Coluna + 2);
                    if (Tab.peca(p1) == null && Tab.peca(p2) == null)
                    {
                        mat[Posic.Linha, Posic.Coluna + 2] = true; 
                    }
                }
            }

            // #jogada especial grande
            if (QtddMovimentos == 0 && !Partida.Xeque)
            {
                Posicao posT2 = new Posicao(Posic.Linha, Posic.Coluna -4);
                if (TestTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posic.Linha, Posic.Coluna - 1);
                    Posicao p2 = new Posicao(Posic.Linha, Posic.Coluna - 2);
                    Posicao p3 = new Posicao(Posic.Linha, Posic.Coluna - 3);
                    if (Tab.peca(p1) == null && Tab.peca(p2) == null && Tab.peca(p3) == null)
                    {
                        mat[Posic.Linha, Posic.Coluna - 2] = true;
                    }
                }
            }

            return mat;
        }
    }
}
