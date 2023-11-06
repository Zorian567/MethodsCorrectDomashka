using System;

namespace MyNamespace
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nEnter the number of values you want to extract max one from (2, 3 or 4, 0 to exit): ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 2:
                    MinMaxOfTwo();
                    break;
                case 3:
                    MinMaxOfThree();
                    break;
                case 4:
                    MinMaxOfFour();
                    break;
                case 0: 
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter correct value!");
                    break;
            }
            Main();
        }

        static void MinMaxOfTwo()
        {
            Console.WriteLine("Enter the first value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first == second)
            {
                Console.WriteLine("Your numbers are equal!");
            }
            else
            {
                int max = Math.Max(first, second);
                Console.WriteLine(max + " is your maximum number!");
                int min = Math.Min(first, second);
                Console.WriteLine(min + " is your minimum value!");
            }
        }

        static void MinMaxOfThree()
        {
            Console.WriteLine("Enter the first value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third value: ");
            int third = Convert.ToInt32(Console.ReadLine());

            if (first == second && second == third)
            {
                Console.WriteLine("Your values are equal!");
            }
            else
            {
                int max1 = Math.Max(first, second);
                int max = Math.Max(max1, third);
                Console.WriteLine(max + " is your maximum value!");
                int min1 = Math.Min(first, second);
                int min = Math.Min(min1, third);
                Console.WriteLine(min + " is your minimum value!");
            }
        }

        static void MinMaxOfFour()
        {
            Console.WriteLine("Enter the first value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third value: ");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth value: ");
            int fourth = Convert.ToInt32(Console.ReadLine());

            if (first == second && second == third && third == fourth)
            {
                Console.WriteLine("Your values are equal!");
            }
            else
            {
                int max1 = Math.Max(first, second);
                int max2 = Math.Max(third, fourth);
                int max = Math.Max(max1, max2);
                Console.WriteLine(max + " is your maximum value!");
                int min1 = Math.Min(first, second);
                int min2 = Math.Min(third, fourth);
                int min = Math.Min(min1, min2);
                Console.WriteLine(min + " is your minimum value!");
            }
            

        }
    }
}
