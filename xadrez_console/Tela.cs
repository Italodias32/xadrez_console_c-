using System;
using NTabuleiro;
using Xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write((8 - i) + " ");
                for(int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimePeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimePeca(Peca peca)
        {
            if(peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor consoleColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca);
                Console.ForegroundColor = consoleColor;
            }
        }

        public static PosicaoXadrez LerPosicaoTeclado()
        {
            string leitura = Console.ReadLine();
            char coluna = leitura[0];
            int linha = int.Parse(leitura[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
