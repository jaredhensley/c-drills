using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProblemOne();
        }

        public static void ProblemOne()
        {
            var counter = 0;

            for (var i = 0; i < 100; i++)
            {
                if (i%3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }

    
}
