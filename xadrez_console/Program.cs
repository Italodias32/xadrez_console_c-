using System;
using NTabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Dama(tabuleiro, Cor.Preta), new Posicao(2, 4));
                tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Branca), new Posicao(0, 7));

               PosicaoXadrez posicaoXadrez = new PosicaoXadrez('a', 1);

                tabuleiro.ColocarPeca(new Bispo(tabuleiro, Cor.Preta), posicaoXadrez.ToPosicao());

                Tela.ImprimirTabuleiro(tabuleiro);

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
