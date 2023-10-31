
namespace Chess.ChessGame
{
    public class Rook
    {
        public void MoveRook(char[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            char rook = board[fromRow, fromCol];

            
            if (Char.ToUpper(rook) == 'R')
            {
                
                if ((toRow <= fromRow + 7 && toCol == fromCol) || (toRow == fromRow && toCol <= fromCol + 7))
                {
                    
                    board[fromRow, fromCol] = ' ';
                    board[toRow, toCol] = rook;
                    Console.WriteLine("Ход успешно выполнен.");
                }
                else
                {
                    Console.WriteLine("Неверный ход для ладьи.");
                }
            }
            else
            {
                Console.WriteLine("На начальной клетке нет ладьи.");
            }
        }
    }
}
