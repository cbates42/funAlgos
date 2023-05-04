using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    internal class NumberPattern
    {
        int n = 9;
        int prevNum;
        int newNum;
        string currentNum;

        public NumberPattern()
        {
            currentNum = n.ToString();
           for(int i = 9; i > 0; i--)
            {
                    Do(n, i);   
                n = n - 1;
            }
          
        }

        public void Do(int n, int i)
        {
            if (i <= 9)
            {
                if (n != 1)
                {
                    currentNum = $"{n - 1}" + $"{currentNum}" + $"{n - 1}";
                    Console.WriteLine(currentNum);
                }
            }
        }

    }
}
