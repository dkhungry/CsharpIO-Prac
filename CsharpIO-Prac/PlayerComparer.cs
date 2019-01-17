using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIO_Prac
{
    class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return x.PPG.CompareTo(y.PPG) * -1;
        }
    }
}
