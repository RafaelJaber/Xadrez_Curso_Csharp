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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 7));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 6));


                Tela.imprimirTabuleiro(tab);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}