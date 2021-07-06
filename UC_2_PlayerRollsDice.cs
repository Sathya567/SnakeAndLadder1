using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeandladderStimulation
{
    class UC_2_PlayerRollsDice
    {
        public static void snake1()
        {
            int position = 0;
            Console.WriteLine("Player is at position: " + position);
            Random random = new Random();
            int droll = 0;
            while (true)
            {
                droll = random.Next(7);
                if (droll != 0) break;

            }
            Console.WriteLine(droll);
        }
    }
}

