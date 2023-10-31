
namespace Chess.ChessGame
{
    public class Pawn
    {
        bool firstStep1=true;
        bool firstStep2=true;
        public void MovePawn(char[,] board, int fromRow, int fromCol, int toRow, int toCol)
        {
            char pawn = board[fromRow, fromCol];

            if (pawn == 'P')
            {
                if (firstStep1==true) 
                {
                    if ((toRow == fromRow + 1 && toCol == fromCol) || (toRow == fromRow + 2 && toCol == fromCol)
                    || board[toRow + 1, toCol + 1] != ' ' || board[toRow - 1, toCol - 1] != ' ')
                    {
                        board[fromRow, fromCol] = ' ';
                        board[toRow, toCol] = pawn;
                        Console.WriteLine("Ход успешно выполнен.");
                    }
                        firstStep1 =false;
                }
                else if (toRow == fromRow + 1 && toCol == fromCol || toRow == fromRow + 1 && toCol == fromCol 
                    || board[toRow+1,toCol+1] != ' ' || board[toRow - 1, toCol - 1] != ' ')
                {
                    board[fromRow, fromCol] = ' ';
                    board[toRow, toCol] = pawn;
                    Console.WriteLine("Ход успешно выполнен.");
                }
                else
                {
                    Console.WriteLine("Неверный ход для пешки.");
                }
            }
            else if(pawn == 'p')
            {
                if (firstStep2 == true)
                {
                    if ((toRow == fromRow + 1 && toCol == fromCol) || (toRow == fromRow + 2 && toCol == fromCol)
                    || board[toRow + 1, toCol + 1] != ' ' || board[toRow - 1, toCol - 1] != ' ')
                    {
                        board[fromRow, fromCol] = ' ';
                        board[toRow, toCol] = pawn;
                        Console.WriteLine("Ход успешно выполнен.");
                    }
                    firstStep1 = false;
                }
                else if (toRow == fromRow + 1 && toCol == fromCol || toRow == fromRow + 1 && toCol == fromCol
                    || board[toRow + 1, toCol + 1] != ' ' || board[toRow - 1, toCol - 1] != ' ')
                {
                    board[fromRow, fromCol] = ' ';
                    board[toRow, toCol] = pawn;
                    Console.WriteLine("Ход успешно выполнен.");
                }
                else
                {
                    Console.WriteLine("Неверный ход для пешки.");
                }
            }
            else
            {
                Console.WriteLine("На начальной клетке нет пешки.");
            }
        }
    }
}
