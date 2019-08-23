using System;
using System.Collections.Generic;
using System.Text;

namespace ludo
{
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
        public void SetPlayerHomeOut(int pl, int pi)
        {
            switch (pl)
            {
                case 1:
                    //Code 5471 = Out
                    player1Home[pi] = 5471;
                    break;
                case 2:
                    //Code 5471 = Out
                    player2Home[pi - 4] = 5471;
                    break;
                case 3:
                    //Code 5471 = Out
                    player3Home[pi - 8] = 5471;
                    break;
                case 4:
                    //Code 5471 = Out
                    player4Home[pi - 12] = 5471;
                    break;
            }

        }
        //Sets defined Piece as in
        public void SetPlayerHomeIn(int pl, int pi)
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
        public int GetIsPieceHome(int pi)
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
}
