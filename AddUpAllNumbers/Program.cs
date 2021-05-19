using System;

namespace AddUpAllNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Total = 0;
            
            for (var number = 1; number <= 50; number++) 
            {
                if (number % 5 == 0 || number % 7 == 0)
                {
                    Total = Total + number;

                    

                } 
            }

            Console.Write($"Total is {Total} ");
        }

    }
}
