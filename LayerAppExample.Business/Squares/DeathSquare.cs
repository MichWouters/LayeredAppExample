using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredAppExample.Business.Squares
{
    public class DeathSquare: Square
    {
        public DeathSquare()
        {
            SquareType = SquareType.Death;
        }

        public override void HandlePlayer(Player player)
        {
            // player.TakeDamage();
            Console.WriteLine($"Player {player.Name} died! Start over");
        }
    }
}
