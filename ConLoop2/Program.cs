using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("First 10 Fibonacci Numbers:");

                for (int i = 0; i < 10; i++)
                {
                    int fibonacciNumber = Fibonacci(i);
                    Console.WriteLine(fibonacciNumber);
                }

                Console.WriteLine("\nEnter the number of elements for the array: ");
                if (int.TryParse(Console.ReadLine(), out int arraySize) && arraySize > 0)
                {
                    int[] randomArray = new int[arraySize];

                    Console.WriteLine($"Enter {arraySize} random integers, one per line:");

                    for (int i = 0; i < arraySize; i++)
                    {
                        if (int.TryParse(Console.ReadLine(), out int randomInt))
                        {
                            randomArray[i] = randomInt;
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input. Please enter a valid integer for element {i + 1}.");
                            i--;
                        }
                    }

                    Console.WriteLine("\nArray of Random Integers:");
                    foreach (int num in randomArray)
                    {
                        Console.WriteLine(num);
                    }

                    int sum = CalculateSum(randomArray);
                    double average = CalculateAverage(randomArray);

                    Console.WriteLine($"\nSum of the array elements: {sum}");
                    Console.WriteLine($"Average of the array elements: {average}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive integer for the array size.");
                }

                // Keep the console window open until the user presses Enter
                Console.ReadLine();
            }

            static int Fibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                int a = 0, b = 1, temp = 0;
                for (int i = 2; i <= n; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }

            static int CalculateSum(int[] array)
            {
                int sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                }
                return sum;
            }

            static double CalculateAverage(int[] array)
            {
                int sum = CalculateSum(array);
                return (double)sum / array.Length;
            }
        }


    }


  

