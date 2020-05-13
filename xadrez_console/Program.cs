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
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                while (!partidaDeXadrez.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partidaDeXadrez.Tabuleiro);

                    Console.WriteLine("\nOrigem: ");
                    Posicao origem = Tela.LerPosicaoTeclado().ToPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.LerPosicaoTeclado().ToPosicao();

                    partidaDeXadrez.ExecutaMovimento(origem, destino);
                }

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
