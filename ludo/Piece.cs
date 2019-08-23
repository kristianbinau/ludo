using System;
using System.Collections.Generic;
using System.Text;

namespace ludo
{
    class Piece
    {
        //=================Fields====================

        private int[] pieceCords = new int[16];
        private string[] pieceName = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", };

        //=================Methods===================
        //-------------------SET---------------------

        //SET piece cordinates by number
        public void SetPieceCords(int pi, int co)
        {
            pieceCords[pi] = co;
        }

        //-------------------GET---------------------

        //GET piece cordinates by number
        public int GetPieceCords(int pi)
        {
            return pieceCords[pi];

        }
        //GET piece name by number
        public string GetPieceName(int pi)
        {
            return pieceName[pi];
        }
    }
}
