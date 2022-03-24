using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 32, 13, 63, 12, 30, 16, 52 };
            int num = 10;
            AddElem(ref arr,num);
        }

        static void AddElem(ref int[] array,int num)
        {
            int[] newArr = new int [array.Length + 1];
            newArr[array.Length] = num;

            for(int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            array = newArr;

            foreach (var show in array)
            {
                Console.Write(" " + show + " ");
            }

        }
    }
}
