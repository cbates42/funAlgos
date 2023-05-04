using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    internal class StringChars
    {
        string quote;
        Dictionary<char, int> prevChars = new Dictionary<char, int>();
        char maxChar;
        char minChar;

        public StringChars()
        {
            Run();
            Console.WriteLine();
        }

        public void Run()
        {
            foreach (char c in quote)
            {
              if(prevChars.ContainsKey(c))
                {
                    prevChars[c] = prevChars[c] + 1;
                }
                prevChars.Add(c, 1);
            }

        }
    }
}
