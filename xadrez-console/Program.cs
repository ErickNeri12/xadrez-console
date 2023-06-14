using xadrez;
using tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}