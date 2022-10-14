using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashain_Task.Arrays
{
    internal class Arrays
    {
        public static void ImplicitlyTypedArray()
        {
            var author_names = new[] { "Shilpa", "Soniya", "Shivi", "Ritika" };

            author_names[3] = "Ravan";

            Console.WriteLine($"List of Authors is: {author_names[3]}");
        }

        public static void JaggedArray()
        {
            int[][] jagged_arr = new int[][]
            {
                new int[] {1, 2, 3, 4},
                new int[] {11, 34, 67},
                new int[] {89, 23},
                new int[] {0, 45, 78, 53, 99}
            };

            jagged_arr[1][2] = 99;

            Console.WriteLine("jaggedArray[1][2]: " + jagged_arr[1][2]);
        }

        public static void MultiDimensionalArray()
        {
            int[,] numbers = { { 2, 3 }, { 4, 5 } };

            Console.WriteLine("Old element at index [0, 0] : " + numbers[0, 0]);

            numbers[0, 0] = 222;

            Console.WriteLine("New element at index [0, 0] : " + numbers[0, 0]);
        }

        public static void SingleDimensionalArray()
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            array1[1] = 2;

            Console.WriteLine(array1[1]);
            Console.WriteLine(weekDays2[3]);
        }
    }
}
