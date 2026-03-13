using System;

namespace BaiTapGeneric
{
    public class MyGenericClass<T>
    {
        public static void Display(T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.Write(element + "  ");
            }
            Console.WriteLine();
        }

        public static T[] Sort(T[] inputArray)
        {
            return inputArray;
        }
    }
}