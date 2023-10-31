

namespace Chess.ChessGame
{
    public class Queen
    {
        public void MoveQueen(char[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            char queen = board[fromRow, fromCol];


            if (Char.ToUpper(queen) == 'Q')
            {

                if (toRow == fromRow || toCol == fromCol || Math.Abs(toRow - fromRow) == Math.Abs(toCol - fromCol))
                {

                    board[fromRow, fromCol] = ' ';
                    board[toRow, toCol] = queen;
                    Console.WriteLine("Ход успешно выполнен.");
                }
                else
                {
                    Console.WriteLine("Неверный ход для королевы.");
                }
            }
            else
            {
                Console.WriteLine("На начальной клетке нет королевы.");
            }
        }

    }
}
