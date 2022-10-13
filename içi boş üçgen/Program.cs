using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucgen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if ((i == 1 && j == 5) || (i == 2 && (j == 4 || j == 6)) || (i == 3 && (j == 3 || j == 7)) || (i == 4 && (j == 2 || j == 8)) || i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}