using System;

namespace Lab01_Exception_Handling_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured.");
            }

            finally
            {
                Console.WriteLine("The program has completed.");
            }
        }

        static void StartSequence()
        {
            string answer = "";
            Console.WriteLine("Enter a number greater than zero.");
            answer = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(answer);
                PopulateMethod(number);
                /*
                GetSumMethod();
                GetProductMethod();
                GetQuotientMethod();
                */


            }
            catch (Exception)
            {
                Console.WriteLine("That is not a number.");
            }

        }

        
        static int[] PopulateMethod(int number)
        {
            try
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
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured.");
                throw;
            }
        }


        /*
        static int GetSumMethod()
        {
            try
            {
                
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured.");
                throw;
            }
            
        }

        static int GetProductMethod()
        {
            try
            {
                
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured.");
                throw;
            }
          

        }

        static decimal GetQuotientMethod()
        {
            try
            {
                
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured.");
                throw;
            }

        }
        */
    }
}
