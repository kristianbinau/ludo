using System;
using System.Collections.Generic;
using System.Text;

namespace ludo
{
    class Dice
    {
        //=================Fields====================

        private Random diceTrow = new Random();
        private int currentDice;

        //=================Methods===================
        //-------------------SET---------------------



        //-------------------GET---------------------

        public int SetNewDice()
        {
            currentDice = diceTrow.Next(1, 7);
            return currentDice;
        }
        public int GetCurrentDice()
        {
            return currentDice;
        }
    }
}
