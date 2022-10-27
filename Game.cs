using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Game
    {
        public int position = 0;
        public void StartTheGame()
        {
            Random random = new Random();
            int num = random.Next(1, 6);
            position = num;

        }
    }
}
