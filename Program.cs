using System;
using tabuleiro;
using ItensXadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            tab.ColocaPeca(new Torre(tab,Cor.Preta),new Posicao(3,4));
            tab.ColocaPeca(new Torre(tab,Cor.Preta),new Posicao(4,3));
            tab.ColocaPeca(new Rei(tab,Cor.Preta),new Posicao(2,7));
            tab.ColocaPeca(new Torre(tab, Cor.Branca), new Posicao(7, 2));
            tab.ColocaPeca(new Rei(tab, Cor.Branca), new Posicao(5, 5));




            Tela.ImprimirTabuleiro(tab);


        }
    }
}
