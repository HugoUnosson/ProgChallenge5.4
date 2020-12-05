using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int fcounter = 0;
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'f')
                {
                    fcounter++;
                }
                if (fcounter == 2)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            if (fcounter == 1)
            {
                Console.WriteLine("-1");
            }
            else if (fcounter == 0)
            {
                Console.WriteLine("-2");
            }

            Console.ReadLine();
        }
    }
}
