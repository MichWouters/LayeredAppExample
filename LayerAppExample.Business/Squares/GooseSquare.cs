using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredAppExample.Business.Squares
{
    public class GooseSquare: Square
    {
        public GooseSquare()
        {
            SquareType = SquareType.Goose;
        }

        public override void HandlePlayer(Player player)
        {
            Console.WriteLine("Player stepped on a goose. Move X squares again");
        }
    }
}
