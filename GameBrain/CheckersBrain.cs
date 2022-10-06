using Domain;

namespace GameBrain;

public class CheckersBrain
{
    private readonly CheckersGameState _state;
    private int v1;
    private int v2;

    public CheckersBrain(CheckersOptions options)
    {
        var boardWidth = options.Width;
        var boardHeight = options.Height;

        if (boardWidth < 4 || boardHeight < 4)
        {
            throw new ArgumentException("Board size too small");
        }

        _state = new CheckersGameState();

        _state.GameBoard = new EGamePiece?[boardWidth, boardHeight];
        var initialX = (boardWidth / 2) - 1;
        var initialY = (boardHeight / 2) - 1;
        //_state.GameBoard[initialX, initialY] = EGamePiece.Black;
        //_state.GameBoard[initialX + 1, initialY] = EGamePiece.White;
        //_state.GameBoard[initialX, initialY + 1] = EGamePiece.White;
        //_state.GameBoard[initialX + 1, initialY + 1] = EGamePiece.Black;
    }

    public CheckersBrain(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public EGamePiece?[,] GetBoard()
    {
        var res = new EGamePiece?[_state.GameBoard.GetLength(0), _state.GameBoard.GetLength(1)];
        Array.Copy(_state.GameBoard, res, _state.GameBoard.Length);
        return res;
    }
}