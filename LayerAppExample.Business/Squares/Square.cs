namespace LayeredAppExample.Business.Squares
{
    public enum SquareType
    {
        Regular = 0,
        Goose = 1,
        Death = 2,
    }

    public class Square
    {
        public int Id { get; set; }
        public SquareType SquareType { get; set; }

        public Square()
        {
            this.SquareType = SquareType.Regular;
        }

        public virtual void HandlePlayer(Player player)
        {
            Console.WriteLine($"Player {player.Name} entered {this.Id}");
            
        }
    }
}