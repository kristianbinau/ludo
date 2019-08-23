using System;
using System.Collections.Generic;
using System.Text;

namespace ludo
{
    class Player
    {
        //=================Fields====================
        private int[] player1 = { 0, 1, 2, 3 };
        private int[] player2 = { 4, 5, 6, 7 };
        private int[] player3 = { 8, 9, 10, 11 };
        private int[] player4 = { 12, 13, 14, 15 };

        private int playingPlayer;

        //=================Methods===================
        //-------------------SET---------------------
        public void SetNextPlayingPlayer()
        {
            if(playingPlayer <= 3)
            {
                playingPlayer++;
            }
            else
            {
                playingPlayer = 1;
            }
        }
        public void SetPlayingPlayer(int i)
        {
            playingPlayer = i;
        }


        //-------------------GET---------------------
        public int GetPlayingPlayer()
        {
            return playingPlayer;
        }
        public int GetPlayingPlayerPiece(int i)
        {
            switch (i)
            {
                case 0:
                    switch (playingPlayer)
                    {
                        case 1:
                            return player1[i];
                        case 2:
                            return player2[i];
                        case 3:
                            return player3[i];
                        case 4:
                            return player4[i];
                        default:
                            return 00000;
                    }
                case 1:
                    switch (playingPlayer)
                    {
                        case 1:
                            return player1[i];
                        case 2:
                            return player2[i];
                        case 3:
                            return player3[i];
                        case 4:
                            return player4[i];
                        default:
                            return 00000;
                    }
                case 2:
                    switch (playingPlayer)
                    {
                        case 1:
                            return player1[i];
                        case 2:
                            return player2[i];
                        case 3:
                            return player3[i];
                        case 4:
                            return player4[i];
                        default:
                            return 00000;
                    }
                case 3:
                    switch (playingPlayer)
                    {
                        case 1:
                            return player1[i];
                        case 2:
                            return player2[i];
                        case 3:
                            return player3[i];
                        case 4:
                            return player4[i];
                        default:
                            return 00000;
                    }
                default:
                    return 00000;
            }
        }
        public int GetPlayerNumberByPiece(int pi)
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
}
