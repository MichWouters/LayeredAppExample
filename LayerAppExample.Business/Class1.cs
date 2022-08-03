using LayeredAppExample.Business;
using LayeredAppExample.Business.Squares;

namespace LayerAppExample.Business
{
    public class Class1
    {
        private GameBoard board = new GameBoard();

        private void PlayGame()
        {
            board.GenerateGameBoard();

            Square whatEverSquare = board.Squares[34];
            //whatEverSquare.HandlePlayer();
        }
    }
}