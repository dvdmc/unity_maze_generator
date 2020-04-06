using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace nsMaze
{
    public class Cell
    {
        //Variable to store if the current cell was used.
        public bool isUsed;
        // Variable to store if the cell is connected to any other and its direction: [N E S W]
        public bool[] connected;
        public Cell()
        {
            //Initialized the cell as not used and not connected.
            isUsed = false;
            connected = new bool[4] { false, false, false, false };
        }
    }
}
