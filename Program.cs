using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Функция "StrangeSum" - обладает сложностью O(N^3).

namespace HomeWork
{
    class Program
    {
        public class TestCaseLesson1Task1
        {
            public long Num { get; set; }
            public bool Ret { get; set; }
            public bool Expected { get; set; }
            public Exception  ExpectedException { get; set; }
        }
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
                    d++;
                }
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
            if (number == 0)
            {
                FibArray = new long[0];
                return 0;
            }
            if(number == 1)
            {
                FibArray = new long[1];
                return 1;
            }
            FibArray = new long[number];
            FibArray[0] = 0;
            FibArray[1] = 1;
            for (int i = 2; i < number; ++i)
            {
                FibArray[i] = FibArray[i-2] + FibArray[i-1];
            }
            return FibArray[number - 1];
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
            //Console.ReadKey();
             


        }
    }
}