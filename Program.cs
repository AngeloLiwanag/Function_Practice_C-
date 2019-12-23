using System;
using System.Collections.Generic;

namespace basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // int[] arr = {1,2,3,4,5};
            // LoopArray(arr);
            // int[] maxArr = {-3, -5, 6, -7};
            // System.Console.WriteLine(FindMax(maxArr));
            // int[] avgArr = {1,2,3,4,5};
            // GetAverage(avgArr);
            // foreach(var i in OddArray()){
            //     System.Console.WriteLine(i);
            // }
            // System.Console.WriteLine(GreaterThanY(arr, 2));
            // SquareArrayValues(arr);
            // EliminateNegative(maxArr);
            // MinMaxAverage(maxArr);
            // ShiftValues(maxArr);
                foreach(var num in NumToString(maxArr))
                {
                if(num is int)
                {
                    System.Console.WriteLine("NumToString: " + num.ToString());
                }
                if(num is string)
                {
                    System.Console.WriteLine("NumToString: " + num.ToString());
                }



        }
        public static void PrintNumbers()
        {
            for (int i = 0; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i = 0; i <= 255; i++)
            {
                if ( i % 2 != 0)
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                System.Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }

        public static void LoopArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine(numbers[i]);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(max < numbers[i])
                {
                    max = numbers[i];
                }
                System.Console.WriteLine();
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double new_sum = sum;
            double length = numbers.Length;
            double avg =  new_sum / length;
            System.Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            List<int> oddList = new List<int>();

            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    oddList.Add(i);
                }
            }
            return oddList.ToArray();
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int num = 0;
            foreach(var n in numbers)
            {
                if (n > y)
                {
                    num ++;
                }
            }
            return num;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for(var i=0; i<numbers.Length; i++)
            {
                Console.WriteLine((numbers[i] * numbers[i]).ToString());
            }
        }

        public static void EliminateNegative(int[] numbers)
        {
            for(int i = 0;  i< numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                    System.Console.WriteLine(numbers[i]);
                }else
                {
                    System.Console.WriteLine(numbers[i]);
                }
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum  = 0;
            int average = 0;
            foreach(var num in numbers)
            {
                if(max < num)
                {
                    max = num;
                }
                if(min > num)
                {
                    min = num;
                }
                sum += num;
            }
            average = sum / numbers.Length;
            System.Console.WriteLine("Max: " + max.ToString() + ", Min: " + min.ToString() + ", Average: " + average.ToString());
        }

        public static void ShiftValues(int[] numbers)
        {
            List<int> newNumbers = new List<int>();
            for(var i  = 1; i <numbers.Length; i++)
            {
                newNumbers.Add(numbers[i]);
            }
            newNumbers.Add(0);
            foreach(var num in newNumbers)
            {
                System.Console.WriteLine(num.ToString());
            }
        }
        
        public static object[] NumToString(int[] numbers)
        {
            List<object> newNumbers = new List<object>();
            for(int i = 0; i<numbers.Length; i++){
                if(numbers[i]<0){
                    newNumbers.Add("Dojo");
                }else{
                    newNumbers.Add(numbers[i]);
                }
            }
            return newNumbers.ToArray();
        }

























    }
}
