using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Players
{
    public interface IPlayer
    {
        public int RollDice();
        public void MovePiece(int index, int dice);
    }
}
