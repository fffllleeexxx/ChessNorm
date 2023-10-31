
namespace Chess.ChessGame
{
    public class Bishop
    {
        public void MoveBishop(char[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            char bishop = board[fromRow, fromCol];


            if (Char.ToUpper(bishop) == 'B')
            {

                if ((Math.Abs(toRow - fromRow) == Math.Abs(toCol - fromCol)) && toCol<=8 && toRow<=8)
                {

                    board[fromRow, fromCol] = ' ';
                    board[toRow, toCol] = bishop;
                    Console.WriteLine("Ход успешно выполнен.");
                }
                else
                {
                    Console.WriteLine("Неверный ход для слона.");
                }
            }
            else
            {
                Console.WriteLine("На начальной клетке нет слона.");
            }
        }



    }
}
