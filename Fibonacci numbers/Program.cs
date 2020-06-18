using System;

namespace Fibonacci_numbers
{
    class Program
    {
        static int Fibonacci(int number)
        {
            // В этом случае делаем возрат "0" т.к. дальнейшие вычисления невозможны
            if (number <= 0)
                return 0;
            // В этом случае делаем возрат "1" т.к. дальнейшие вычисления невозможны
            if (number == 1)
                return 1;

            var result = Fibonacci(number - 1) + Fibonacci(number - 2);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(6));
            Console.ReadKey();
        }
    } 
}
