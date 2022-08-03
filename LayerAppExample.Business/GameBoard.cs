using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredAppExample.Business.Squares;

namespace LayeredAppExample.Business
{
    internal class GameBoard
    {
        public List<Square> Squares = new List<Square>();
        private SquareFactory factory = new SquareFactory();

        private int[] gooseIds = new[] { 5, 9, 14 };

        public List<Square> GenerateGameBoard()
        {
            for (int i = 0; i < 63; i++)
            {
                if (gooseIds.Contains(i))
                {
                    Squares.Add(factory.Create(i, SquareType.Goose));
                }
                else if (i == 58)
                {
                    Squares.Add(factory.Create(i, SquareType.Death));
                }
                else
                {
                    Squares.Add(factory.Create(i, SquareType.Regular));
                }
            }

            return Squares;
        }
    }
}
