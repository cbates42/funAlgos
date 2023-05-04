using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    internal class Pythagorean
    {
        int a = 1;
        int b = 2;
        int c = 3;
        int aS;
        int bS;
        int cS;
        int iterations = 0;
        int attempts;
        bool Continue = true;
        bool triplet;

        void Iterate()
        {
            while (Continue)
            {
                Pythagorate(a, b, c);
                a++;
                iterations++;
            }
         }

        public void CheckForTriplet(int a)
        {
           for(a = 1; a < 10; a++)
            {
                for(b = a+1; b < c; b++)
                {

                    c = (a * a) + (b * b);

                }
            }

          
        }

        public void Pythagorate(int a, int b, int c)
        {
            bool result = (a * a) + (b * b) == (c * c);

            switch (result)
            {
                case true:
                    Continue = false;
                    Console.WriteLine($"{a}, {b}, {c} => {a * a} + {b * b} = {c * c}");
                    break;
                case false:
                    break;
            }

        }



    }





}

