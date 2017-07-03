using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace TesteRecursaoT1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Este teste retorna as posiveis posições para a peça preta que está em 3,2 e a peça preta que está em 0,0. 
        /// A ordem de verificação deve ser noroeste, depois nordeste, sudeste e sudoeste. 
        /// </summary>
        [TestMethod]
        public void P3_TesteCapturaSimples()
        {
            char[,] board = {
                                    {' ',' ',' ', ' '},
                                    {' ',' ',' ', ' '},
                                    {' ',' ',' ', ' '},
                                    {' ',' ',' ', ' '},
                                    {' ',' ',' ', ' '}

                                 /* {'P','B',' ', 'B'},
                                    {' ',' ','B', ' '},
                                    {' ','B',' ', ' '},
                                    {'P',' ','P', ' '},
                                    {' ','P',' ', 'P'}*/
                            };

            Damas d = new Damas();
            Assert.AreEqual("1,1 2,2 3,3", d.MovimentosPossiveis(board, new Point(0, 0), board.GetLength(0), board.GetLength(1)));
            //Assert.AreEqual("1,0 2,3", d.MovimentosPossiveis(board, new Point(3, 2), board.GetLength(0), board.GetLength(1)));
            //Assert.AreEqual("", d.MovimentosPossiveis(board, new Point(0, 0), board.GetLength(0), board.GetLength(1)));
        }
        
        /// <summary>
        /// Este teste retorna as posiveis posições para a peça preta que está em 4,4, podendo capturar outras peças. 
        /// A ordem de verificação deve ser noroeste, depois nordeste, sudeste e sudoeste. 
        /// </summary>
        [TestMethod]
        public void P3_TesteCapturaRecursiva()
        {
            char[,] board = {
                                    {' ',' ',' ',' ', ' '},
                                    {' ','B',' ','B', ' '},
                                    {' ',' ',' ',' ', ' '},
                                    {' ',' ',' ','B', ' '},
                                    {' ',' ',' ',' ', 'P'}
                            };

            Damas d = new Damas();
            Assert.AreEqual("2,2 0,0 0,4", d.MovimentosPossiveis(board, new Point(4, 4), board.GetLength(0), board.GetLength(1)));
        }
        
        /// <summary>
        /// Este teste retorna as posiveis posições para a peça preta que está em 3,3, podendo capturar outras peças, inclusive para tras. 
        /// A ordem de verificação deve ser noroeste, depois nordeste, sudeste e sudoeste. 
        /// </summary>
        [TestMethod]
        public void P3_TesteCapturaRecursivaTras()
        {
            char[,] board = {
                                    {' ',' ',' ',' ', ' '},
                                    {' ','B',' ','B', ' '},
                                    {' ',' ',' ',' ', ' '},
                                    {' ','B',' ','B', ' '},
                                    {' ',' ',' ',' ', 'P'}
                            };

            Damas d = new Damas();
            Assert.AreEqual("2,2 0,0 0,4 4,0", d.MovimentosPossiveis(board, new Point(4, 4), board.GetLength(0), board.GetLength(1)));
        }
    }
}
