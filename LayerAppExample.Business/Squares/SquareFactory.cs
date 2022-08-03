using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredAppExample.Business.Squares
{
    public class SquareFactory
    {
        public Square Create(int id, SquareType type)
        {
            switch (type)
            {
                case SquareType.Goose:
                    return new GooseSquare { Id = id };
                case SquareType.Death:
                    return new DeathSquare { Id = id };
                default:
                    return new Square { Id = id };
            }
        }
    }
}
