using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        private int[,] board;
        private int currentPlayer;
        public enum State {WIN, DRAW, PLAY }

        public Game()
        {
            board = new int[3, 3];
            currentPlayer = 1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = 0;
        }

        public void printBoard()
        {
            Console.WriteLine(" ----------------------- ");
            printBoxRow(0);
            printBoxRow(1);
            printBoxRow(2);
        }

        public void printBoxRow(int row)
        {
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|   " + getOccupant(board[row, 0]) + "   |   "+ 
                getOccupant(board[row, 1]) + "   |   " + 
                getOccupant(board[row, 2]) + "   |");
            Console.WriteLine("|_______|_______|_______|");
        }

        public string getOccupant(int player)
        {
            switch (player)
            {
                case 1:
                    return "1";
                case 2:
                    return "2";
                default:
                    return " ";
            }
        }

        public void nextPlayer()
        {
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }

        public int[] getInput()
        {
            int row, column;
            string input;
            do
            {
                do
                {
                    Console.Write("Player " + currentPlayer + 
                        ", choose a row (0 <= row <= 2):");
                    input = Console.ReadLine();
                    input = (canConvert(input) ? input : "-1");
                    row = Convert.ToInt32(input);
                } while (!validateRange(row));
                do
                {
                    Console.Write("Player " + currentPlayer + 
                        ", choose a column (0 <= column <= 2):");
                    input = Console.ReadLine();
                    input = (canConvert(input) ? input : "-1");
                    column = Convert.ToInt32(input);
                } while (!validateRange(column));
            } while (!validateSelection(row, column));
            return new int[] { row, column };
        }

        public bool canConvert(string input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] < '0' || input[i] > '9')
                    return false;
            }
            return true;
        }

        public bool validateRange(int value)
        {
            if (value < 0 || value > 2)
            {
                Console.WriteLine("Invalid range. Try again");
                return false;
            }
            return true;  
        }

        public bool validateSelection(int row, int column){
            if(board[row, column] != 0)
            {
                Console.WriteLine("This space is not available");
                return false;
            }
            return true;
        }

        public State getGameState(int currentPlayer)
        {
            if (gameWon(currentPlayer))
            {
                printBoard();
                Console.WriteLine("Player " + currentPlayer + " won!!!");
                return State.WIN;
            }
            if (gameTie())
            {
                printBoard();
                Console.WriteLine("Cat's game!!!");
                return State.DRAW;
            }
            nextPlayer();
            return State.PLAY;
        }

        public bool gameWon(int currentPlayer)
        {
            //diagonals
            if (vectorCheck(0, 0, 1, 1))
                return true;
            if (vectorCheck(2, 0, -1, 1))
                return true;

            //horizontals
            for(int i = 0; i < 3; i++)
            {
                if (vectorCheck(i, 0, 0, 1))
                    return true;
            }

            //verticals
            for(int i = 0; i < 3; i++)
            {
                if (vectorCheck(0, i, 1, 0))
                    return true;
            }

            return false;

        }

        public bool vectorCheck(int row, int column, int xVector, int yVector)
        {
            for (int d = 0; d < 3; d++)
            {
                if (board[row + (d * xVector), column + (d * yVector)] 
                    == currentPlayer)
                {
                    if (d == 2)
                        return true;
                }
                else
                {
                    d = 3;
                }
            }
            return false;
        }

        public bool gameTie()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i, j] == 0)
                        return false;
            return true;
        }

        public void run()
        {
            Console.WriteLine("TIC-TAC-TOE TIME!!!");
            int[] selection;
            do
            {
                printBoard();
                selection = getInput();
                board[selection[0], selection[1]] = currentPlayer;                
            } while (getGameState(currentPlayer) == State.PLAY);
        }

        static void Main(string[] args)
        {
            Game game = new Game();
            game.run();
        }
    }
}
