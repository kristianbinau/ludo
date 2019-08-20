using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo
{
    class Ludo
    {
        class Game
        {
            //=================Fields====================
            private int playingPlayer;


            //=================Methods===================
            //-------------------SET---------------------
            public void reset()
            {
                //Home reset
                Board board = new Board();
                for (int i = 1; i <= 4; i++)
                {
                    for (int p = 0; p <= 3; p++)
                    {
                        board.setPlayerHomeIn(i, p);
                    }
                    Console.WriteLine("Player " + i + " has been reset.");
                }
                Console.WriteLine("All players are home.");

                //Coordinate reset
                Piece piece = new Piece();
                for (int i = 0; i <= 15; i++)
                {
                    piece.setPieceCords(i, 5471);                    
                }
                Console.WriteLine("All coordinates has been reset.");

                playingPlayer = 1;

                Console.WriteLine("Everything has been reset.");
            }


            //-------------------GET---------------------
            public int GetPlayingPlayer()
            {
                return playingPlayer;
            }

            public void GetAllInfo()
            {
                for(int i = 0; i <= 15; i++)
                {
                    Piece piece = new Piece();
                    if(piece.getPieceCords(i) == 5471)
                    {

                    }
                    else
                    {

                    }
                }
            }


        }
        class Board
        {
            //=================Fields====================
            private int[] player1Home = { 0, 1, 2, 3 };
            private int[] player2Home = { 4, 5, 6, 7 };
            private int[] player3Home = { 8, 9, 10, 11 };
            private int[] player4Home = { 12, 13, 14, 15 };
            


            //=================Methods===================
            //-------------------SET---------------------

            //Sets defined Piece as out
            public void setPlayerHomeOut(int pl, int pi)
            {
                switch(pl)
                {
                    case 1:
                        //Code 5471 = Out
                        player1Home[pi] = 5471;
                        break;
                    case 2:
                        //Code 5471 = Out
                        player2Home[pi] = 5471;
                        break;
                    case 3:
                        //Code 5471 = Out
                        player3Home[pi] = 5471;
                        break;
                    case 4:
                        //Code 5471 = Out
                        player4Home[pi] = 5471;
                        break;
                }

            }
            //Sets defined Piece as in
            public void setPlayerHomeIn(int pl, int pi)
            {
                switch (pl)
                {
                    case 1:
                        player1Home[pi] = pi;
                        break;
                    case 2:
                        player2Home[pi] = pi + 4;
                        break;
                    case 3:
                        player3Home[pi] = pi + 8;
                        break;
                    case 4:
                        player4Home[pi] = pi + 12;
                        break;
                }

            }

            //-------------------GET---------------------

            //Returns piece number if its inside, returns 21 if out.
            public int getIsPieceHome(int pi)
            {
                Boolean isHome = false;
                switch (pi)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        if (player1Home[pi] == pi)
                        {
                            isHome = true;
                        }
                        else
                        {
                            isHome = false;
                        }
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        if (player2Home[pi] == pi)
                        {
                            isHome = true;
                        }
                        else
                        {
                            isHome = false;
                        }
                        break;
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        if (player3Home[pi] == pi)
                        {
                            isHome = true;
                        }
                        else
                        {
                            isHome = false;
                        }
                        break;
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        if (player4Home[pi] == pi)
                        {
                            isHome = true;
                        }
                        else
                        {
                            isHome = false;
                        }
                        break;
                }
                if (isHome == true)
                {
                    return pi;
                }
                else
                {
                    //Code 21 = Out
                    return 21;
                }
            }


        }
        class Piece
        {
            //=================Fields====================

            private int[] pieceCords = new int[16];
            private string[] pieceName = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", };

            //=================Methods===================
            //-------------------SET---------------------

            //SET piece cordinates by number
            public void setPieceCords(int pi, int co)
            {
                pieceCords[pi] = co;
            }

            //-------------------GET---------------------

            //GET piece cordinates by number
            public int getPieceCords(int pi)
            {
                return pieceCords[pi];
            }
            //GET piece name by number
            public string getPieceName(int pi)
            {
                return pieceName[pi];
            }
        }
        class Dice
        {
            //=================Fields====================

            private Random diceTrow = new Random();

            //=================Methods===================
            //-------------------SET---------------------



            //-------------------GET---------------------

            public int getDice()
            {
                int trow = diceTrow.Next(1, 7);
                return trow;
            }
        }
        class Player
        {
            //=================Fields====================
            private int[] player1 = { 0, 1, 2, 3 };
            private int[] player2 = { 4, 5, 6, 7 };
            private int[] player3 = { 8, 9, 10, 11 };
            private int[] player4 = { 12, 13, 14, 15 };

            //=================Methods===================
            //-------------------SET---------------------



            //-------------------GET---------------------
            public int getPlayerNumberByPiece(int pi)
            {
                int playerNumber;
                switch (pi)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        playerNumber = 1;
                        break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        playerNumber = 2;
                        break;
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        playerNumber = 3;
                        break;
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        playerNumber = 4;
                        break;
                    default:
                        playerNumber = 0;
                        break;
                }

                return playerNumber;
            }

        }
        class Ui
        {
            //=================Fields====================



            //=================Methods===================
            //-------------------SET---------------------



            //-------------------GET---------------------



        }
        class Program
        {
            static void Main(string[] args)
            {
                //Variables

                Game game = new Game();
                game.reset();

                Dice trow = new Dice();



                game.GetPlayingPlayer();




            }
        }
    }
}
