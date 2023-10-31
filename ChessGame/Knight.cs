

namespace Chess.ChessGame
{
    public class Knight
    {
        public void MoveKnight(char[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            char knight = board[fromRow, fromCol];

            
            if (Char.ToUpper(knight) == 'N')
            {
                
                if ((toRow == fromRow + 2 && toCol == fromCol + 1) || (toRow == fromRow + 2 && toCol == fromCol - 1) ||
                    (toRow == fromRow - 2 && toCol == fromCol + 1) || (toRow == fromRow - 2 && toCol == fromCol - 1) ||
                    (toRow == fromRow + 1 && toCol == fromCol + 2) || (toRow == fromRow - 1 && toCol == fromCol + 2) ||
                    (toRow == fromRow + 1 && toCol == fromCol - 2) || (toRow == fromRow - 1 && toCol == fromCol - 2))
                {
                    
                    board[fromRow, fromCol] = ' ';
                    board[toRow, toCol] = knight;
                    Console.WriteLine("Ход успешно выполнен.");
                }
                else
                {
                    Console.WriteLine("Неверный ход для коня.");
                }
            }
            else
            {
                Console.WriteLine("На начальной клетке нет коня.");
            }
        }
    }
}
