
//Copy pasted
using GameBrain;

namespace ConsoleUI;

public static class UI
{
    public static void DrawGameBoard(EGamePiece?[,] board)
    {
        var cols = board.GetLength(0);
        var rows = board.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("+---");
            }

            Console.WriteLine("+");

            for (int j = 0; j < cols; j++)
            {
                Console.Write("| ");
                var pieceStr =
                    board[j, i] == null
                        ? " "
                        : board[j, i] == EGamePiece.Black
                            ? "X"
                            : "O";

                Console.Write(pieceStr);
                Console.Write(" ");
            }

            Console.WriteLine("|");
        }

        for (int j = 0; j < cols; j++)
        {
            Console.Write("+---");
        }

        Console.WriteLine("+");

        /*
            A    B
          +---+---+
        2 | X | O |
          +---+---+
        1 | O | X |
          +---+---+




         */
    }
}