using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.tabuleiro;

namespace Xadrez.xadez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);


            // Acima
            pos.definirValores(posicao.linha - 1, posicao.coluna + 0);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                while (tab.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                    if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                        break;
                    }
                    pos.linha--;
                }
            }

            // Abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna + 0);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                while (tab.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                    if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                        break;
                    }
                    pos.linha++;
                }
            }

            // Direita
            pos.definirValores(posicao.linha - 0, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                while (tab.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                    if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                        break;
                    }
                    pos.coluna++;
                }
            }

            // Esquerda
            pos.definirValores(posicao.linha - 0, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                while (tab.posicaoValida(pos) && podeMover(pos))
                {
                    mat[pos.linha, pos.coluna] = true;
                    if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                    {
                        break;
                    }
                    pos.coluna--;
                }
            }


            return mat;
        }
    }
}
