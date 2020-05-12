using NTabuleiro;

namespace Xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tabuleiro, Cor cor) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "P";
        }

    }
}
