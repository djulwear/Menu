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
        //Othello Example Mid-board XO/OX
        var initialX = (boardWidth / 2) - 1;
        var initialY = (boardHeight / 2) - 1;
        //_state.GameBoard[initialX, initialY] = EGamePiece.Black;
        //_state.GameBoard[initialX + 1, initialY] = EGamePiece.White;

        //Not Playable Board

        var cols = boardWidth;
        var rows = boardHeight;
        var line = 1;

        for (int columb=0; columb < cols; columb++,line++)
        {
            if (columb % 2 == 0 && line % 2 == 0)
            {
                _state.GameBoard[columb, line] = EGamePiece.EmptyNotPlayable;
            }
            else
            {
                if (columb % 2 != 0 && line % 2 != 0)
                {
                    _state.GameBoard[columb, line] = EGamePiece.EmptyNotPlayable;
                }
            }
        }

        //var marker = 
        //var 
        //_state.GameBoard[marker,marker] = EGamePiece.EmpryNotPlayable;

    }

    public EGamePiece?[,] GetBoard()
    {
        var res = new EGamePiece?[_state.GameBoard.GetLength(0), _state.GameBoard.GetLength(1)];
        Array.Copy(_state.GameBoard, res, _state.GameBoard.Length);
        return res;
    }
}