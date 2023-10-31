
//создание шахматной доски
using Chess.ChessGame;

char[,] board = new char[8, 8];
InitializeBoard(board);

// Вывод доски
PrintBoard(board);

//игрок
int player = 1;

//мат
bool kingDead=false;
bool end = true;
 


while (end)
{
    if (player == 1)
    {
        Console.WriteLine("Ходят белые");
    }
    else if (player == 2) 
    {
        Console.WriteLine("Ходят черные");
    }


    Console.WriteLine("Выбирайте фигуру, которой будете ходить и напишите ее координаты");
    string figure = Console.ReadLine();
    int _oldX = Convert.ToInt32(Console.ReadLine());
    int _oldY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Напишите, куда хотите сходить");
    int _newX = Convert.ToInt32(Console.ReadLine());
    int _newY = Convert.ToInt32(Console.ReadLine());



    if (player == 1)
    {
        if (figure == "Pawn" || figure == "P")
        {
            Pawn pawn = new Pawn();
            kingDead = IsKingDead(_newX, _newY, board);
            pawn.MovePawn(board, _oldX, _oldY, _newX, _newY);          
            PrintBoard(board);
            player++;
        }
        else if (figure == "King" || figure == "K")
        {
            King king = new King();
            kingDead = IsKingDead(_newX, _newY, board);
            king.MoveKing(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player++;   
        }
        else if (figure == "Rook" || figure == "R")
        {
            Rook rook = new Rook();
            kingDead = IsKingDead(_newX, _newY, board);
            rook.MoveRook(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player++;
        }
        else if (figure == "Knight" || figure == "N")
        {
            Knight knight = new Knight();
            kingDead = IsKingDead(_newX, _newY, board);
            knight.MoveKnight(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player++;
        }
        else if (figure == "Bishop" || figure == "B")
        {
            Bishop bishop = new Bishop();
            kingDead = IsKingDead(_newX, _newY, board);
            bishop.MoveBishop(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player++;
        }
        else if (figure == "Queen" || figure == "Q")
        {
            Queen queen = new Queen();
            kingDead = IsKingDead(_newX, _newY, board);
            queen.MoveQueen(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player++;
        }
    }
    else if(player == 2)
    {
        if (figure == "pawn" || figure == "P")
        {
            Pawn pawn = new Pawn();
            kingDead = IsKingDead(_newX, _newY, board);
            pawn.MovePawn(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player--;
        }
        else if (figure == "king" || figure == "k")
        {
            King king = new King();
            kingDead = IsKingDead(_newX, _newY, board);
            king.MoveKing(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player--;
        }
        else if (figure == "rook" || figure == "r")
        {
            Rook rook = new Rook();
            kingDead = IsKingDead(_newX, _newY, board);
            rook.MoveRook(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player--;
        }
        else if (figure == "knight" || figure == "n")
        {
            Knight knight = new Knight();
            kingDead = IsKingDead(_newX, _newY, board);
            knight.MoveKnight(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player--;
        }
        else if (figure == "bishop" || figure == "b")
        {
            Bishop bishop = new Bishop();
            kingDead = IsKingDead(_newX, _newY, board);
            bishop.MoveBishop(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player--;
        }
        else if (figure == "queen" || figure == "q")
        {
            Queen queen = new Queen();
            kingDead = IsKingDead(_newX, _newY, board);
            queen.MoveQueen(board, _oldX, _oldY, _newX, _newY);
            PrintBoard(board);
            player--;
        }
    }

    if(kingDead==true)
    {
        end = false; break;
    }      
}

if(player==1)
{
    Console.WriteLine("Победа черных");
}
else if(player==2)
{
    Console.WriteLine("Победа белых");
}



static void InitializeBoard(char[,] board)
    {
        // Заполнение пустыми клетками
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                board[row, col] = ' ';
            }
        }

        // Установка фигур
        // Пешки
        for (int col = 0; col < 8; col++)
        {
            board[1, col] = 'P'; // белые пешки
            board[6, col] = 'p'; // черные пешки
        }

        // Ладьи
        board[0, 0] = 'R'; // белая ладья слева
        board[0, 7] = 'R'; // белая ладья справа
        board[7, 0] = 'r'; // черная ладья слева
        board[7, 7] = 'r'; // черная ладья справа

        // Кони
        board[0, 1] = 'N'; // белый конь слева
        board[0, 6] = 'N'; // белый конь справа
        board[7, 1] = 'n'; // черный конь слева
        board[7, 6] = 'n'; // черный конь справа

        // Слоны
        board[0, 2] = 'B'; // белый слон слева
        board[0, 5] = 'B'; // белый слон справа
        board[7, 2] = 'b'; // черный слон слева
        board[7, 5] = 'b'; // черный слон справа

        // Ферзи
        board[0, 3] = 'Q'; // белый ферзь
        board[7, 3] = 'q'; // черный ферзь

        // Короли
        board[0, 4] = 'K'; // белый король
        board[7, 4] = 'k'; // черный король
    }

    static void PrintBoard(char[,] board)
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    static bool IsKingDead(int newX, int newY, char [,] board)
    {
        if (board[newX, newY] == 'K' || board[newX, newY] == 'k')
        {
             return true;
        }
        else { return false; }
    }



    






