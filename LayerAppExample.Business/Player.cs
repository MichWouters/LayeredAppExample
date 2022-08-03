using LayeredAppExample.Business.Squares;

namespace LayeredAppExample.Business
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Picture { get; set; }

        public string Colour { get; set; }

        public Square CurrentSquare { get; set; }
    }
}
