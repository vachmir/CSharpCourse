using System;
using System.Collections.Generic;
using System.Text;

namespace BaisicOperations
{
    class Loops
    {
        public void While()
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 23);
        }

        public void For()
        {
            for (int i = 0; i < 23; i++)
            {
                for (i = 0; i < 23; i++)
                {
                    if (i == 13) // If i is even,
                        continue;
                    if (i == 16)
                        break;
                    Console.WriteLine(i);
                }
            }
        }

        public void Foreach()
        {
            foreach (char c in "beer") // c is the iteration variable
                Console.WriteLine(c);

        }
    }
}
