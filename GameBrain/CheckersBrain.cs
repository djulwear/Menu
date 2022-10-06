//Copy pasted
using GameBrain;

namespace ConsoleUI;

public static class UI
{
    public static void DrawGameBoard(EGamePiece?[,] board)
    {
        var cols = board.GetLength(0);
        var rows = board.GetLength(1);
        var line = board.GetLength(1);

        Console.Write(" ");
        for (int i = 0; i < rows; i++, line--)
        {
            //отрисовка горизонтальных линий
            for (int j = 0; j < cols; j++)
            {
                Console.Write("+---");
            }

            Console.WriteLine("+");
            Console.Write(line);

            //заполнение блоков 
            for (int j = 0; j < cols; j++)
            {
                if (j % 2 == 0 && line % 2 == 0)
                {
                    Console.Write("|III");
                }
                else
                {
                    if (j % 2 != 0 && line % 2 != 0)
                    {
                        Console.Write("|III");
                    }
                    else
                    {
                        Console.Write("|");
                        var pieceStr =
                        board[j, i] == EGamePiece.EmptyNotPlayable
                        ? "III"
                        : board[j, i] == null
                            ? "  "
                            : board[j, i] == EGamePiece.Black
                                ? " X"
                                : " O";

                        Console.Write(pieceStr);
                        Console.Write(" ");
                    }
                }
            }

            Console.WriteLine("|");
            Console.Write(" ");
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