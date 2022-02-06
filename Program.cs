using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Функция "StrangeSum" - обладает сложностью O(N^3).

namespace HomeWork
{
    class Program
    {
  
        /// <summary>
        /// Вычисляет является ли число, переданное в параметре, простым
        /// </summary>
        /// <param name="number"></param>
        /// <returns>если простое, то true, иначе false</returns>
        static bool IsPrimeNumber(long number)
        {
            long d = 0;
            long i = 2;
            for (; i < number; ++i)
            {
                if (number % i == 0)
                {
                    return false;
                    
                }
                d++;
            }
            if(d == 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Вычисляет ряд Фибоначчи без рекурсии.
        /// </summary>
        /// <param name="number - количество членов ряда"></param>
        /// <param name="FibArray - массив вычисленных чисел"></param>
        /// <returns>Последний член ряда</returns>
        static long CalculateFibonachi(int number, out long[] FibArray)
        {
            if (number == 0 || number == 1)
            {
                FibArray = new long[number];
                return number;
            }
           
            FibArray = new long[number];
            FibArray[0] = 0;
            FibArray[1] = 1;
            for (int i = 2; i < number; ++i)
            {
                FibArray[i] = FibArray[i-2] + FibArray[i-1];
            }
            return FibArray[number-1];
        }
       
        private static void Fibonacci_Rec_Temp(long a, long b, long counter, long len, ref long[] FibArray)
        {
            if (counter <= len)
            {
                FibArray[counter-1] =  a;
                Fibonacci_Rec_Temp(b, a + b, counter + 1, len, ref FibArray);
            }
        }
        static void CalculateFibonachiRecursion(long num, ref long[] myFib)
        {
            Fibonacci_Rec_Temp(0, 1, 1, num, ref myFib);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ряда Фибоначчи.");
            int number = int.Parse(Console.ReadLine());
            long[] MyFib = Array.Empty<long>();
            long LastFib = CalculateFibonachi(number, out MyFib);
            foreach (long fibonachi in MyFib)
            {
                Console.Write($"{ fibonachi}, ");
            }
            Array.Clear(MyFib, 0, MyFib.Length);
            System.Console.WriteLine("\nРекурсивное вычисление:");
            CalculateFibonachiRecursion(number, ref MyFib);
            foreach (long fibonachi in MyFib)
            {
                Console.Write($"{ fibonachi}, ");
            }

            //Console.ReadKey();



        }
    }
}