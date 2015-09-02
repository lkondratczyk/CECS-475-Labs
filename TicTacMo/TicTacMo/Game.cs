////////////////////////////////////////////////////////
//  author: Lyndon Kondratczyk
//  version: 9/2/15
//
//  description: You're average console tic-tac-toe game
////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        private const int BOARDSIZE = 3;
        private int[,] board;
        private int currentPlayer;           //will be 1 or 2
        public enum State {WIN, DRAW, PLAY } //all possible states of the game

        /*  Constructor for the game */
        public TicTacToe()
        {
            board = new int[BOARDSIZE, BOARDSIZE];
            currentPlayer = 1;
            for (int i = 0; i < BOARDSIZE; i++)
                for (int j = 0; j < BOARDSIZE; j++)
                    board[i, j] = 0;
        }

        /*  Prints the current contents of the board */
        public void printBoard()
        {
            Console.WriteLine(" ----------------------- ");
            printBoxRow(0);
            printBoxRow(1);
            printBoxRow(2);
        }

        /*  Prints a row of the board (printBoard() helper)

            @param int row The desired row to print
         */
        private void printBoxRow(int row)
        {
            Console.WriteLine("|       |       |       |");
            Console.WriteLine("|   " + getOccupant(board[row, 0]) + "   |   "+ 
                getOccupant(board[row, 1]) + "   |   " + 
                getOccupant(board[row, 2]) + "   |");
            Console.WriteLine("|_______|_______|_______|");
        }

        /*  Retreives a string to represent the player

            @param int player The integer representing the current player

            @return string A string representing the player
        */
        private string getOccupant(int player)
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

        /*  Rotates the currentPlayer to the next player */
        public void nextPlayer()
        {
            currentPlayer = (currentPlayer == 1) ? 2 : 1;
        }

        /*  Gets user input for desired square

            @return The int[] representing the coordinates of player selection
        */
        public int[] getInput()
        {
            int row, column;
            string input;
            Console.WriteLine("Player " + currentPlayer + "'s turn.");
            do
            {
                //get first input
                do
                {
                    Console.Write("Player " + currentPlayer + 
                        ": choose a row (0 <= row <= 2):");
                    input = Console.ReadLine(); // read input
                    input = (canConvert(input) ? input : "-1");
                    row = (String.IsNullOrEmpty(input)) ? -1 : 
                        Convert.ToInt32(input); //check for no input
                } while (!validateRange(row));
                //get second input
                do
                {
                    Console.Write("Player " + currentPlayer + 
                        ": choose a column (0 <= column <= 2):");
                    input = Console.ReadLine(); //read input
                    input = (canConvert(input) ? input : "-1");
                    column = (String.IsNullOrEmpty(input)) ? -1 : 
                        Convert.ToInt32(input); //check for no input
                } while (!validateRange(column));
            } while (!validateSelection(row, column));
            return new int[] { row, column };
        }

        /*  Validates user input
            
            @param string input The string of user input from the scanner

            @return
        */
        public bool canConvert(string input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] < '0' || input[i] > '9' || String.IsNullOrEmpty(input))
                    return false;
            }
            return true;
        }

        /*  Checks the range of input to see if it is within bounds
            
            @param int value The user entry

            @return bool True if inputi s within bounds
        */
        public bool validateRange(int value)
        {
            if (value < 0 || value > 2)
            {
                Console.WriteLine("Invalid range. Try again");
                return false;
            }
            return true;  
        }

        /*  Validates availibility of selected coordinates

            @param int row The row the user selected
            @param int column The column the user selected

            @return bool True if the space is available        
        */
        public bool validateSelection(int row, int column){
            if(board[row, column] != 0)
            {
                Console.WriteLine("This space is not available");
                return false;
            }
            return true;
        }

        /*  Gets the enumerated state of the game

            @ param int The current Player (used for winner detection).

            @return State The enumerated state of the game.       
        */
        public State getGameState(int currentPlayer)
        {
            if (gameWon(currentPlayer))
            {
                Console.WriteLine("Player " + currentPlayer + " won!!!");
                return State.WIN;
            }
            if (gameTie())
            {
                Console.WriteLine("Cat's game!!!");
                return State.DRAW;
            }
            nextPlayer();
            return State.PLAY;
        }

        /*  Uses the current player to check for hte winner

            @param int currentPlayer The current player (only possible winner)

            @param bool True if the currentPlayer won
        */
        public bool gameWon(int currentPlayer)
        {
            //diagonals
            if (vectorCheck(0, 0, 1, 1))
                return true;
            if (vectorCheck(2, 0, -1, 1))
                return true;
            //horizontals
            for(int i = 0; i < BOARDSIZE; i++)
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

        /*  Check for winner given start point and direction

            @param int row Starting row to check
            @param int column Starting column to check

            @param int yVector Vertical direction vector
            @param int xVector Horizontal direction vector
        */
        public bool vectorCheck(int row, int column, int yVector, int xVector)
        {
            for (int d = 0; d < 3; d++)
            {
                if (board[row + (d * yVector), column + (d * xVector)] 
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

        /*  Checks for tie condition (all spaces filled and no winner)

            @return bool True if all spaces filled and no winner
        */
        public bool gameTie()
        {
            for (int i = 0; i < BOARDSIZE; i++)
                for (int j = 0; j < BOARDSIZE; j++)
                    if (board[i, j] == 0)
                        return false;
            return true;
        }

        /*  Controls the flow of the game */
        public void Play()
        {
            Console.WriteLine("TIC-TAC-TOE TIME!!!");
            int[] selection;
            do
            {
                selection = getInput();
                board[selection[0], selection[1]] = currentPlayer;
                printBoard();
            } while (getGameState(currentPlayer) == State.PLAY);
        }

        /* The main method */
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            game.printBoard();
            game.Play();
        }
    }
}
