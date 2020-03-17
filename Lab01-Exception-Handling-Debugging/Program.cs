using System;

namespace Lab01_Exception_Handling_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }

        static void StartSequence()
        {
            string answer = "";
            Console.WriteLine("Enter a number greater than zero.");
            answer = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(answer);
                /*PopulateMethod(number);*/
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a number.");
            }
        }

        /*
        static int[] PopulateMethod(number)
        {
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter a number {i + 1} of {array.Length}");
                string input = Console.ReadLine();
                int convert = Convert.ToInt32(input);
                array[i] = convert;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            {

            }
        }
        */

        /*
        static int GetSumMethod()
        {
            
        }

        static int GetProductMethod()
        {

        }

        static decimal GetQuotientMethod()
        {

        }
        */
    }
}
