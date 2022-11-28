using Xadrez.tabuleiro;
using Xadrez.xadez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                PosicaoXadrez pos = new PosicaoXadrez('c', 7);

                Console.WriteLine(pos.toPosicao());

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}