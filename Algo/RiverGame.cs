using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    internal class RiverGame
    {
        public int time;
        public int timeLimit;
        Friend friend1 = new Friend() { Name = "friend1", speed = 3, loc = "left" };
        Friend friend2 = new Friend() { Name = "friend2", speed = 6 }; 
        Friend friend3 = new Friend() { Name = "friend3", speed = 7 };
        Friend friend4 = new Friend() { Name = "friend4", speed = 9 };


        public RiverGame()
        {
            time = 30;

            while(time > 0)
            {
              
            }
        }

        public void Travel(Friend travel1, Friend travel2)
        {
        
            time = time - travel2.speed;

            Console.WriteLine(travel1.Name + travel2.Name + "travel to the other side.") ;
            Console.WriteLine(time);
        }

        public void TravelBack(Friend travel1)
        {

        }


    }
}
