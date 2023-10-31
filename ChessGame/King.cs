
namespace Chess.ChessGame
{
    public class King
    {
        public void MoveKing(char[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            char king = board[fromRow, fromCol];

            
            if (Char.ToUpper(king) == 'K')
            {
                
                if ((toRow == fromRow + 1 && toCol == fromCol) || (toRow == fromRow - 1 && toCol == fromCol) ||
                    (toRow == fromRow && toCol == fromCol + 1) || (toRow == fromRow && toCol == fromCol - 1) ||
                    (toRow == fromRow + 1 && toCol == fromCol + 1) || (toRow == fromRow + 1 && toCol == fromCol - 1) ||
                    (toRow == fromRow - 1 && toCol == fromCol + 1) || (toRow == fromRow - 1 && toCol == fromCol - 1))
                {
                    
                    board[fromRow, fromCol] = ' ';
                    board[toRow, toCol] = king;
                    Console.WriteLine("Ход успешно выполнен.");
                }
                else
                {
                    Console.WriteLine("Неверный ход для короля.");
                }
            }
            else
            {
                Console.WriteLine("На начальной клетке нет короля.");
            }
        }      
    }
}
