using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;


namespace TesteRecursaoT1
{
    public class Damas
    {
        
        public string MovimentosPossiveis(char [,] b, Point posicao, int linhas, int colunas)
        {
            string aux = " ";

            //sudeste
            if ((posicao.X == colunas || posicao.Y == linhas))
            {
                return "";
            }
            else if (b[posicao.X + 1, posicao.Y + 1] == ' ')
            {
                aux += ((posicao.X) + 1) + "," + ((posicao.Y) + 1) + MovimentosPossiveis(b, new Point(posicao.X + 1, posicao.Y + 1), linhas, colunas);
            }
            else
            {
                if ((posicao.X+2 >= colunas || posicao.Y+2 >= linhas))
                {
                    return "";
                }
                else
                    aux += ((posicao.X) + 2) + "," + ((posicao.Y) + 2) + MovimentosPossiveis(b, new Point(posicao.X + 2, posicao.Y + 2), linhas, colunas);
            }
            //FIM-sudeste



            return aux;
        }

    }
}
