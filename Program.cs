using System;
using tabuleiro;
using ItensXadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocaPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocaPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocaPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));


            Tela.ImprimirTabuleiro(tab);


        }
    }
}
