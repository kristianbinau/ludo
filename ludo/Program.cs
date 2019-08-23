using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ludo
{
    class Ludo
    {
        //=================Fields====================
        

        class Program
        {
            //Variables
            Piece piece = new Piece();
            Board board = new Board();
            Dice dice = new Dice();
            Player player = new Player();
            int run = 1;

            //=================Methods===================
            //-------------------SET---------------------

            //Reset the game
            public void Reset()
            {
                //Home reset
                for (int i = 1; i <= 4; i++)
                {
                    for (int p = 0; p <= 3; p++)
                    {
                        board.SetPlayerHomeIn(i, p);
                    }
                    Console.WriteLine("Player " + i + " has been reset.");
                }
                Console.WriteLine("All players are home.");

                //Coordinate reset
                
                for (int i = 0; i <= 15; i++)
                {
                    piece.SetPieceCords(i, 5471);                    
                }
                Console.WriteLine("All coordinates has been reset.");

                player.SetPlayingPlayer(1);

                Console.WriteLine("Everything has been reset.");
                Console.WriteLine(" ");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(" ");
            }
            //Sets a new Dice
            public int SetNewDice()
            {
                return dice.SetNewDice();
            }

            //-------------------GET---------------------

            //Writes where every piece is currently
            public void GetAllInfo()
            {
                Console.WriteLine(" ");
                for (int i = 0; i <= 15; i++)
                {
                    if(piece.GetPieceCords(i) == 5471)
                    {
                        Console.WriteLine(piece.GetPieceName(i) + " er hjemme.");
                    }
                    else if (piece.GetPieceCords(i) >= 5500)
                    {
                        Console.WriteLine(piece.GetPieceName(i) + " er færdig.");
                    }
                    else
                    {
                        Console.WriteLine(piece.GetPieceName(i) + " står på " + piece.GetPieceCords(i));
                    }
                }
            }
            
            
            //States the options the player has
            public void GetOptions()
            {
                string[] playingPlayerPieceName = new string[4];

                for (int i = 0; i <=3; i++)
                {
                    playingPlayerPieceName[i] = piece.GetPieceName(player.GetPlayingPlayerPiece(i));
                }

                Console.WriteLine(" ");
                Console.WriteLine("Det er spiller {0} tur, du kan flytte på {1}, {2}, {3}, {4}.", player.GetPlayingPlayer(), playingPlayerPieceName[0], playingPlayerPieceName[1], playingPlayerPieceName[2], playingPlayerPieceName[3]);
                Console.WriteLine("Du har slået en {0} terning. Hvad gør du?", GetDice());

            }
            
            
            //Gets player respons and starts related functions
            public void PlayerRespons()
            {
                string playerRespons;
                int intRespons = 0;
                int moveType = 0;
                int moveTo;

                playerRespons = Console.ReadLine();

                switch (player.GetPlayingPlayer())
                {
                    case 1:
                        switch (playerRespons)
                        {
                            case "a":
                            case "A":
                                intRespons = 0;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "b":
                            case "B":
                                intRespons = 1;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "c":
                            case "C":
                                intRespons = 2;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "d":
                            case "D":
                                intRespons = 3;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                        }
                        break;
                    case 2:
                        switch (playerRespons)
                        {
                            case "e":
                            case "E":
                                intRespons = 4;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "f":
                            case "F":
                                intRespons = 5;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "g":
                            case "G":
                                intRespons = 6;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "h":
                            case "H":
                                intRespons = 7;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                        }
                        break;
                    case 3:
                        switch (playerRespons)
                        {                           
                            case "i":
                            case "I":
                                intRespons = 8;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "j":
                            case "J":
                                intRespons = 9;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "k":
                            case "K":
                                intRespons = 10;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "l":
                            case "L":
                                intRespons = 11;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                        }
                        break;
                    case 4:
                        switch (playerRespons)
                        {
                            case "m":
                            case "M":
                                intRespons = 12;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "n":
                            case "N":
                                intRespons = 13;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "o":
                            case "O":
                                intRespons = 14;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                            case "p":
                            case "P":
                                intRespons = 15;
                                moveType = CheckIsMovePossible(intRespons);
                                break;
                        }
                        break;
                }

                switch (moveType)
                {
                    case 0:

                        break;
                    case 1:
                        moveTo = piece.GetPieceCords(intRespons) + GetDice();
                        Console.WriteLine("Player {0}, har rykket {1} fra {2} til {3}.",
                            player.GetPlayingPlayer(), piece.GetPieceName(intRespons), piece.GetPieceCords(intRespons), moveTo);
                        piece.SetPieceCords(intRespons, moveTo);
                        break;
                    case 2:
                        switch (player.GetPlayingPlayer())
                        {
                            case 1:
                                moveTo = 2;
                                piece.SetPieceCords(intRespons, moveTo);
                                board.SetPlayerHomeOut(player.GetPlayingPlayer(), intRespons);
                                Console.WriteLine("Player {0}, har rykket {1} fra hjem til {2}.", 
                                    player.GetPlayingPlayer(), piece.GetPieceName(intRespons), moveTo);
                                break;
                            case 2:
                                moveTo = 17;
                                piece.SetPieceCords(intRespons, moveTo);
                                board.SetPlayerHomeOut(player.GetPlayingPlayer(), intRespons);
                                Console.WriteLine("Player {0}, har rykket {1} fra hjem til {2}.",
                                    player.GetPlayingPlayer(), piece.GetPieceName(intRespons), moveTo);
                                break;
                            case 3:
                                moveTo = 32;
                                piece.SetPieceCords(intRespons, moveTo);
                                board.SetPlayerHomeOut(player.GetPlayingPlayer(), intRespons);
                                Console.WriteLine("Player {0}, har rykket {1} fra hjem til {2}.",
                                    player.GetPlayingPlayer(), piece.GetPieceName(intRespons), moveTo);
                                break;
                            case 4:
                                moveTo = 47;
                                piece.SetPieceCords(intRespons, moveTo);
                                board.SetPlayerHomeOut(player.GetPlayingPlayer(), intRespons);
                                Console.WriteLine("Player {0}, har rykket {1} fra hjem til {2}.",
                                    player.GetPlayingPlayer(), piece.GetPieceName(intRespons), moveTo);
                                break;
                        }
                        break;
                    case 3:
                        moveTo = 5500;
                        Console.WriteLine("Player {0}, har rykket {1} fra {2} til slut.",
                            player.GetPlayingPlayer(), piece.GetPieceName(intRespons), piece.GetPieceCords(intRespons));
                        piece.SetPieceCords(intRespons, moveTo);
                        break;
                }


            }
            
            
            //Checks if the move is possible
            public int CheckIsMovePossible(int Piece)
            {
                int pieceLocation = piece.GetPieceCords(Piece);
                int finalPieceLocation = pieceLocation + GetDice();

                if(pieceLocation == 5471)
                {
                    if (GetDice() == 6)
                    {
                        return CheckForDestruction(2, finalPieceLocation, Piece); //Check for destruction of other pieces
                    }
                    else
                    {
                        return 0; //Cant be moved out
                    }
                }
                else
                {
                    switch (player.GetPlayingPlayer())
                    {
                        case 1:
                            if(finalPieceLocation >= 61 && pieceLocation - 6 <= 55)
                            {
                                return 3; //Move to finish
                            }
                            else
                            {
                                return CheckForDestruction(1, finalPieceLocation, Piece); //Check for destruction of other pieces
                            }
                        case 2:
                            if (finalPieceLocation >= 16 && pieceLocation -6 <= 10)
                            {
                                return 3; //Move to finish
                            }
                            else
                            {
                                return CheckForDestruction(1, finalPieceLocation, Piece); //Check for destruction of other pieces
                            }
                        case 3:
                            if (finalPieceLocation >= 31 && pieceLocation - 6 <= 25)
                            {
                                return 3; //Move to finish
                            }
                            else
                            {
                                return CheckForDestruction(1, finalPieceLocation, Piece); //Check for destruction of other pieces
                            }
                        case 4:
                            if (finalPieceLocation >= 46 && pieceLocation - 6 <= 40)
                            {
                                return 3; //Move to finish
                            }
                            else
                            {
                                return CheckForDestruction(1, finalPieceLocation, Piece); //Check for destruction of other pieces - Returns 1 if no destruction occurs
                            }
                        default:
                            return 0;
                    }
                }
            }
            
            
            //Checks if a piece is gonna land on another piece
            public int CheckForDestruction(int i, int final, int Piece)
            {
                int moveOut = 0;
                int finalLocation = 0;

                switch (i)
                {
                    case 1:
                        finalLocation = final;
                        break;
                    case 2:
                        switch (player.GetPlayingPlayer())
                        {
                            case 1:
                                moveOut = 2;
                                break;
                            case 2:
                                moveOut = 17;
                                break;
                            case 3:
                                moveOut = 32;
                                break;
                            case 4:
                                moveOut = 47;
                                break;
                        }
                        finalLocation = moveOut;
                        break;
                }
                for(int n = 0; n <= 15; n++)
                {
                    int pieceCords = piece.GetPieceCords(n);
                    if (pieceCords == finalLocation)
                    {
                        int deadPiece = n;
                        int alivePiece = Piece;

                        piece.SetPieceCords(n, 5471);
                        switch (player.GetPlayingPlayer())
                        {
                            case 1:
                                board.SetPlayerHomeIn(player.GetPlayingPlayer(), n);
                                break;
                            case 2:
                                board.SetPlayerHomeIn(player.GetPlayingPlayer(), n - 4);
                                break;
                            case 3:
                                board.SetPlayerHomeIn(player.GetPlayingPlayer(), n - 8);
                                break;
                            case 4:
                                board.SetPlayerHomeIn(player.GetPlayingPlayer(), n - 12);
                                break;
                        }
                        Console.WriteLine("Player {0} har smidt {1} hjem!", player.GetPlayingPlayer(), piece.GetPieceName(deadPiece));
                        
                    }
                }
                return i;
            }

            public void NextPlayer()
            {
                player.SetNextPlayingPlayer();
            }

            //Gets the current dice, dont change anything
            public int GetDice()
            {
                return dice.GetCurrentDice();
            }

            
            //Main
            static void Main(string[] args)
            {
                Program program = new Program();

                program.Reset();

                do
                {
                    program.GetAllInfo();

                    program.SetNewDice();

                    program.GetOptions();

                    program.PlayerRespons();

                    program.NextPlayer();

                } while (program.run == 1);


            }
        } 
    }
}
