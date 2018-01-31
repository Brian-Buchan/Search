using System;
using System.Diagnostics;

namespace Self_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed);

            myArray myARR = new myArray();
            GenerateArray(ref myARR.arr);
            DoLinearSearch(ref myARR.arr);
            DoBianarySearch(ref myARR.arr);
            DoLinearSearch(ref myARR.arr);
            DoBianarySearch(ref myARR.arr);
        }

        class myArray
        {
            public int[] arr = new int[10];
        }

        private static void DoLinearSearch(ref int[] arr)
        {
            DisplayArray(ref arr);
            Console.WriteLine("value to search - Linear");
            Search(Int32.Parse(Console.ReadLine()), ref arr);
        }

        private static void DoBianarySearch(ref int[] arr)
        {
            DisplayArray(ref arr);
            Console.WriteLine("value to search - Bianary");
            Search(Int32.Parse(Console.ReadLine()), ref arr);
        }

        private static void GenerateArray(ref int[] arr)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 100);
            }
        }

        private static void DisplayArray(ref int[] arr)
        {
            string arrayString = "";
            for (int i = 0; i < arr.Length; i++)
            {
                arrayString += arr[i].ToString() + " ";
            }
            Console.WriteLine(arrayString);
        }

        private static void Search(int searchItem, ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchItem)
                {
                    MoveToFront(i, ref arr);
                    return;
                }
            }
            Console.WriteLine("Doesn't Exsist");
        }

        private static void MoveToFront(int index, ref int[] arr)
        {
            for (int i = index; i > 0; i--)
            {
                int key = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = key;
            }
        }
    }
}