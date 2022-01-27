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

            try
            {
                tab.ColocaPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocaPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.ColocaPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));


                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
