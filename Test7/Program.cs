using System;
using System.Collections.Generic;

namespace Test7
{
    class Program
    {
        // Solution1 from attached document
        private static bool CheckOrder(List<int> array1, List<int> array2)
        {
            var position = array1.IndexOf(array2[0]);
            for (var i = 1; i < array2.Count; i++)
            {
                var testPosition = array1.IndexOf(array2[i]);
                if (position > testPosition)
                    return false;
                position = testPosition;
            }
            return true;
        }
        
        // Solution 2 from attached document
        private static bool CheckOrder(int[] array1, int[] array2)
        {
            var resultVector = new int[array1.Length];
            for (var i = 0; i < array2.Length; i++)
            {
                resultVector[i] = GetPosition(array1, array2[i]);
            }

            return IsSorted(resultVector);
        }

        private static int GetPosition(int[] array, int element)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                    return i;
            }

            throw new Exception("Array is empty or element does not exist");
        }

        private static bool IsSorted(int[] array)
        {
            for(var i = 0; i < array.Length-1; i++)
                if (array[i] > array[i + 1])
                    return false;
            return true;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(CheckOrder(new List<int>{1,2,3,4,5,6,7}, new List<int>{2,4,7})); // True
            Console.WriteLine(CheckOrder(new int[] {1,2,3,4,5,6,7},new int[]{4,2,7})); // False
        }
    }
}