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
            //while (position <= 100)
           // {
                int next = random.Next(1, 3);
                switch(next)
                {
                    case 0:
                        Console.WriteLine("This is No Play");
                        position = position;
                        break;
                    case 1:
                        Console.WriteLine("This is Lader");
                        int val =random.Next(1, 6);
                        position = position + val;
                        break;
                    case 2:
                        Console.WriteLine("This is Snake");
                        int val2 = random.Next(1, 6);
                        position=position - val2;
                        break;
                    default:
                        Console.WriteLine("Nothing");
                        break;

                }


           // }
            Console.WriteLine("Current Position: " + position);
        }
    }
}
