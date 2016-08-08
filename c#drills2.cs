using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Hello
    {
        private static void Main()
        {
            Hello hello = new Hello();
          hello.Exercise5();
    
        }

        public void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }

        public void Exercise2()
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("enter random number");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")

                {
                    Console.WriteLine(sum);
                    return;
                }
                else
                {
                    sum = sum + Convert.ToInt32(input);
                }
           
            }
            
        }

        public void Exercise3()
        {
            Console.WriteLine("enter a number into factorial calculator");
            var input = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (var i = 1;  i <= input; i++)
            {
                factorial = factorial*i;
            }
            Console.WriteLine(factorial);
        }

        public void Exercise4()
        {
            var counter = 0;
            var random = new Random().Next(1, 10);

            while (counter < 4)
            {
                
                Console.WriteLine("pick a number, between 1 and 10");

                var guess = Console.ReadLine();

                if (Convert.ToInt32(guess) == random)
                {
                    Console.WriteLine("You won!");
                    return;
                }
                else
                {
                    Console.WriteLine("Try Again!");
                    counter++;
                }
            }
        }

        public void Exercise5()
        {
            Console.WriteLine("enter a string of numbers, separated by a comma");

            var numbers = Console.ReadLine();

            var parsedNumbers = numbers.Split(',');

            var max = Convert.ToInt32(parsedNumbers[0]);

            foreach (var str in parsedNumbers)
            {
               var strg = Convert.ToInt32(str);
                if (strg > max)
                {
                    max = strg;
                }
            }
            // 
            Console.WriteLine(max);
        }


        
        
    }

}