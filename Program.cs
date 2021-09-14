using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            saveThePrisoner(7, 19, 2);
            int[] sticksArray = new int[] {5, 4, 4, 2, 2, 8 };
            int[] sticksArray2 = new int[] { 1, 2, 3, 4, 3, 3, 2, 1 };
            cutTheSticks(sticksArray2);
            Console.ReadKey();
        }
        public static void saveThePrisoner(int n, int m, int s)
        {
            Console.WriteLine("Started saveThePrisoner Algorithm");
            int toWarn = (m + s -1) % n;
                if(toWarn == 0)
                {
                    toWarn = n;
                }
                Console.WriteLine(toWarn);
            Console.WriteLine("Ended saveThePrisoner Algorithm");
        }

        public static void cutTheSticks(int[] arr)
        {
            Console.WriteLine("Started cutTheSticks Algorithm ");
            int count = 1;
            //sort the sticks
            Array.Sort(arr);
            int currentStick = arr[0]; //initialize first element in array
            int currentLength = arr.Length;
            Console.WriteLine("[");
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i] == currentStick)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(currentLength);
                    currentLength -= count;
                    count = 1;
                    currentStick = arr[i];
                }
            }
            Console.WriteLine(currentLength);
            Console.WriteLine("]");
            Console.WriteLine("Started cutTheSticks Algorithm");
        }
    }
}
